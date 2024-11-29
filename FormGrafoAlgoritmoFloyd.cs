using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalEstructuraDatosGrupo4
{
    public partial class FormGrafoAlgoritmoFloyd : Form
    {
        private GrafoFloyd grafoFloyd = new GrafoFloyd();

        public FormGrafoAlgoritmoFloyd()
        {
            InitializeComponent();
            this.Load += FormGrafoFloyd_Load;
        }

        private void FormGrafoFloyd_Load(object sender, EventArgs e)
        {
            cbCriterioBusqueda.Items.Add("Codigo");
            cbCriterioBusqueda.Items.Add("Nombre");
            cbCriterioBusqueda.Items.Add("FechaIngreso");
            cbCriterioBusqueda.Items.Add("FechaVencimiento");
            cbCriterioBusqueda.Items.Add("PrecioCompra");
            cbCriterioBusqueda.Items.Add("PrecioVenta");

            cbCriterioOrdenamiento.Items.Add("Codigo");
            cbCriterioOrdenamiento.Items.Add("Nombre");
            cbCriterioOrdenamiento.Items.Add("FechaIngreso");
            cbCriterioOrdenamiento.Items.Add("FechaVencimiento");
            cbCriterioOrdenamiento.Items.Add("PrecioCompra");
            cbCriterioOrdenamiento.Items.Add("PrecioVenta");

            cbcategoria.Items.Add("Bolsa 1 Lb");
            cbcategoria.Items.Add("Bolsa 2 Lb");
            cbcategoria.Items.Add("Paquete");
            cbcategoria.Items.Add("Vaso");
        }

        private void ActualizarDataGridView(List<ProductoColasCirculares> lista = null)
        {
            dgvProducto.Rows.Clear();
            var productosAmostrar = lista ?? grafoFloyd.ObtenerTodosLosNodos();

            foreach (var producto in productosAmostrar)
            {
                dgvProducto.Rows.Add(
                    producto.Codigo,
                    producto.NombreProducto,
                    producto.Descripcion,
                    producto.Categoria,
                    producto.FechaIngreso.ToShortDateString(),
                    producto.FechaVencimiento.ToShortDateString(),
                    producto.PrecioCompra,
                    producto.PrecioVenta
                );
            }
        }


        private void LimpiarCampos()
        {
            txtcodigo.Clear();
            txtproducto.Clear();
            txtdescripcion.Clear();
            cbcategoria.SelectedIndex = -1;
            dtpfechaingreso.Value = DateTime.Now;
            dtpfechavencimiento.Value = DateTime.Now;
            txtpreciocompra.Clear();
            txtprecioventa.Clear();
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

            if (!decimal.TryParse(txtpreciocompra.Text, out decimal precioCompra) ||
                !decimal.TryParse(txtprecioventa.Text, out decimal precioVenta))
            {
                MessageBox.Show("Por favor, ingrese precios válidos.");
                return;
            }
            try
            {
                ProductoColasCirculares nuevoProducto = new ProductoColasCirculares
                {
                    Codigo = txtcodigo.Text.Trim(),
                    NombreProducto = txtproducto.Text.Trim(),
                    Descripcion = txtdescripcion.Text.Trim(),
                    Categoria = cbcategoria.SelectedItem?.ToString(),
                    FechaIngreso = dtpfechaingreso.Value,
                    FechaVencimiento = dtpfechavencimiento.Value,
                    PrecioCompra = decimal.Parse(txtpreciocompra.Text),
                    PrecioVenta = decimal.Parse(txtprecioventa.Text)
                };

                grafoFloyd.AgregarNodo(nuevoProducto);
                ActualizarDataGridView();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                        if (grafoFloyd.EliminarNodo(codigoProducto))
                        {
                            MessageBox.Show($"Producto con código {codigoProducto} eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Producto con código {codigoProducto} no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbCriterioBusqueda.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un criterio de búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string criterio = cbCriterioBusqueda.SelectedItem.ToString();
            string busqueda = txtBusqueda.Text;

            List<ProductoColasCirculares> resultados = grafoFloyd.BuscarProducto(criterio, busqueda);

            if (resultados.Count == 0)
            {
                MessageBox.Show("No se encontraron productos que coincidan con el criterio de búsqueda.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ActualizarDataGridView(resultados);
        }



        private void btnAscendente_Click(object sender, EventArgs e)
        {
            if (cbCriterioOrdenamiento.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un criterio de ordenamiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string criterio = cbCriterioOrdenamiento.SelectedItem.ToString();
            List<ProductoColasCirculares> productosOrdenados = grafoFloyd.OrdenarProductos(criterio, true);
            ActualizarDataGridView(productosOrdenados);
        }

        private void btnDescendente_Click(object sender, EventArgs e)
        {
            if (cbCriterioOrdenamiento.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un criterio de ordenamiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string criterio = cbCriterioOrdenamiento.SelectedItem.ToString();
            List<ProductoColasCirculares> productosOrdenados = grafoFloyd.OrdenarProductos(criterio, false);
            ActualizarDataGridView(productosOrdenados);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
