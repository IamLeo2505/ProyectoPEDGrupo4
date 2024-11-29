using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalEstructuraDatosGrupo4
{
    public partial class FormShakerSort : Form
    {
        private List<ProductoColasCirculares> productos;

        public FormShakerSort()
        {
            InitializeComponent();
            this.Load += FormShakerSort_Load;
            productos = new List<ProductoColasCirculares>();
        }

        private void FormShakerSort_Load(object sender, EventArgs e)
        {
            cbCriterio.Items.Add("Codigo");
            cbCriterio.Items.Add("Nombre");
            cbCriterio.Items.Add("FechaIngreso");
            cbCriterio.Items.Add("FechaVencimiento");
            cbCriterio.Items.Add("PrecioCompra");
            cbCriterio.Items.Add("PrecioVenta");

            cbcategoria.Items.Add("Bolsa 1 Lb");
            cbcategoria.Items.Add("Bolsa 2 Lb");
            cbcategoria.Items.Add("Paquete");
            cbcategoria.Items.Add("Vaso");
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            // Validación de entrada
            if (string.IsNullOrWhiteSpace(txtcodigo.Text) ||
                string.IsNullOrWhiteSpace(txtproducto.Text) ||
                string.IsNullOrWhiteSpace(txtdescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtpreciocompra.Text) ||
                string.IsNullOrWhiteSpace(txtprecioventa.Text) ||
                cbcategoria.SelectedItem == null)
            {
                MessageBox.Show("Por favor, rellene todos los campos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtpreciocompra.Text, out decimal precioCompra) ||
                !decimal.TryParse(txtprecioventa.Text, out decimal precioVenta))
            {
                MessageBox.Show("Por favor, ingrese precios válidos.");
                return;
            }

            if (dtpfechaingreso.Value.Date >= dtpfechavencimiento.Value.Date)
            {
                MessageBox.Show("La fecha de vencimiento no puede ser igual o menor a la fecha de ingreso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Creación de producto
            var nuevoProducto = new ProductoColasCirculares
            {
                Codigo = txtcodigo.Text,
                NombreProducto = txtproducto.Text,
                Descripcion = txtdescripcion.Text,
                Categoria = cbcategoria.SelectedItem.ToString(),
                FechaIngreso = dtpfechaingreso.Value,
                FechaVencimiento = dtpfechavencimiento.Value,
                PrecioCompra = precioCompra,
                PrecioVenta = precioVenta
            };
            productos.Add(nuevoProducto);
            LimpiarCampos();
            ActualizarDataGridView();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Eliminar productos seleccionados
            if (dgvProducto.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow fila in dgvProducto.SelectedRows)
                {
                    if (!fila.IsNewRow)
                    {
                        productos.RemoveAt(fila.Index);
                    }
                }
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarDataGridView()
        {
            dgvProducto.Rows.Clear();
            foreach (var producto in productos)
            {
                dgvProducto.Rows.Add(
                    producto.Codigo, producto.NombreProducto,
                    producto.Descripcion, producto.Categoria,
                    producto.FechaIngreso, producto.FechaVencimiento,
                    producto.PrecioCompra, producto.PrecioVenta);
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

        private void btnAscendente_Click(object sender, EventArgs e)
        {
            if (productos.Count == 0)
            {
                MessageBox.Show("No hay productos para ordenar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbCriterio.SelectedItem != null)
            {
                string criterio = cbCriterio.SelectedItem.ToString();
                ShakerSort.Ordenar(productos, criterio, true); // Orden ascendente usando ShakerSort
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un criterio de ordenación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDescendente_Click(object sender, EventArgs e)
        {
            if (productos.Count == 0)
            {
                MessageBox.Show("No hay productos para ordenar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbCriterio.SelectedItem != null)
            {
                string criterio = cbCriterio.SelectedItem.ToString();
                ShakerSort.Ordenar(productos, criterio, false); // Orden descendente usando ShakerSort
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un criterio de ordenación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
