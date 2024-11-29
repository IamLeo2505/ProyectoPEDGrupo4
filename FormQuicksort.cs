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
    public partial class FormQuicksort : Form
    {
        private List<ProductoColasCirculares> productos;
        public FormQuicksort()
        {
            InitializeComponent();
            this.Load += FormQuicksort_Load;
            productos = new List<ProductoColasCirculares>();
        }

        private void FormQuicksort_Load(object sender, EventArgs e)
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
            if (string.IsNullOrWhiteSpace(txtcodigo.Text) ||
                string.IsNullOrWhiteSpace(txtproducto.Text) ||
                string.IsNullOrWhiteSpace(txtdescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtpreciocompra.Text) ||
                string.IsNullOrWhiteSpace(txtprecioventa.Text) ||
                cbcategoria.SelectedItem == null)
            {
                MessageBox.Show("Por favor, rellene todos los campos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!decimal.TryParse(txtpreciocompra.Text, out decimal precioCompra) || !decimal.TryParse(txtprecioventa.Text, out decimal precioVenta))
            {
                MessageBox.Show("Por favor, ingrese precios válidos.");
                return;
            }
            else if (dtpfechaingreso.Value.Date >= dtpfechavencimiento.Value.Date)
            {
                MessageBox.Show("La fecha de vencimiento no puede ser igual o menor a la fecha de ingreso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                try
                {
                    ProductoColasCirculares nuevoProducto = new ProductoColasCirculares
                    {
                        Codigo = txtcodigo.Text,
                        NombreProducto = txtproducto.Text,
                        Descripcion = txtdescripcion.Text,
                        Categoria = cbcategoria.SelectedItem.ToString(),
                        FechaIngreso = dtpfechaingreso.Value,
                        FechaVencimiento = dtpfechavencimiento.Value,
                        PrecioCompra = decimal.Parse(txtpreciocompra.Text),
                        PrecioVenta = decimal.Parse(txtprecioventa.Text)
                    };
                    productos.Add(nuevoProducto);
                    LimpiarCampos();
                    ActualizarDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
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
                Quicksort.Ordenar(productos, criterio, true);
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
                Quicksort.Ordenar(productos, criterio, false);
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
