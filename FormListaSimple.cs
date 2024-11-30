using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFinalEstructuraDatosGrupo4
{
    public partial class FormListaSimple : Form
    {
        public ListaProducto listaProductos;

        public FormListaSimple()
        {
            InitializeComponent();
            this.Load += FormListaSimple_Load;
            listaProductos = new ListaProducto();
        }

        private void FormListaSimple_Load(object sender, EventArgs e)
        {
            cbCriterio.Items.AddRange(new string[] { "Codigo", "Nombre", "FechaIngreso", "FechaVencimiento", "PrecioCompra", "PrecioVenta" });
            cbcategoria.Items.AddRange(new string[] { "Bolsa 1 Lb", "Bolsa 2 Lb", "Paquete", "Vaso" });
        }

        private void LimpiarCampos()
        {
            txtcodigo.Clear();
            txtproducto.Clear();
            txtdescripcion.Clear();
            txtpreciocompra.Clear();
            txtprecioventa.Clear();
            cbcategoria.SelectedIndex = -1;
            dtpfechaingreso.Value = DateTime.Now;
            dtpfechavencimiento.Value = DateTime.Now;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcodigo.Text) || string.IsNullOrEmpty(txtproducto.Text) ||
                string.IsNullOrEmpty(txtpreciocompra.Text) || string.IsNullOrEmpty(txtprecioventa.Text) ||
                cbcategoria.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione una categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dtpfechaingreso.Value.Date >= dtpfechavencimiento.Value.Date)
            {
                MessageBox.Show("La fecha de vencimiento no puede ser igual o menor a la fecha de ingreso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!decimal.TryParse(txtpreciocompra.Text, out decimal precioCompra) || !decimal.TryParse(txtprecioventa.Text, out decimal precioVenta))
            {
                MessageBox.Show("Por favor, ingrese precios válidos.");
                return;
            }
            else if (!rbtInicio.Checked && !rbtFinal.Checked)
            {
                MessageBox.Show("Selecione la ubicaión del dato a añadir.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                ProductoColasCirculares nuevoProducto = new ProductoColasCirculares(
                    txtcodigo.Text,
                    txtproducto.Text,
                    txtdescripcion.Text,
                    cbcategoria.SelectedItem.ToString(),
                    dtpfechaingreso.Value,
                    dtpfechavencimiento.Value,
                    decimal.Parse(txtpreciocompra.Text),
                    decimal.Parse(txtprecioventa.Text)
                );

                if (rbtInicio.Checked)
                {
                    listaProductos.AgregarAlInicio(nuevoProducto);
                }
                else if (rbtFinal.Checked)
                {
                    listaProductos.AgregarAlFinal(nuevoProducto);
                }

                ActualizarDataGridView();
                LimpiarCampos();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para los precios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProducto.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow fila in dgvProducto.SelectedRows)
                {
                    if (!fila.IsNewRow && fila.Cells["column0"].Value != null)
                    {
                        string codigoProducto = fila.Cells["column0"].Value.ToString();
                        listaProductos.EliminarProducto(codigoProducto);
                    }
                }
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarDataGridView(List<ProductoColasCirculares> lista = null)
        {
            dgvProducto.Rows.Clear();
            var productosAmostrar = lista ?? listaProductos.ObtenerProductos();

            foreach (var producto in productosAmostrar)
            {
                dgvProducto.Rows.Add(producto.Codigo, producto.NombreProducto, producto.Descripcion, producto.Categoria,
                    producto.FechaIngreso.ToShortDateString(), producto.FechaVencimiento.ToShortDateString(),
                    producto.PrecioCompra, producto.PrecioVenta);
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (cbCriterio.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un criterio de búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string criterio = cbCriterio.SelectedItem.ToString();
            string busqueda = txtBusqueda.Text;

            List<ProductoColasCirculares> resultados = listaProductos.BuscarProducto(criterio, busqueda);

            if (resultados.Count == 0)
            {
                MessageBox.Show("No se encontraron productos que coincidan con el criterio de búsqueda.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ActualizarDataGridView(resultados);
        }

        private void FormListaSimple_Load_1(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
