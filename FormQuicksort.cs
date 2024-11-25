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
        // Lista para almacenar los productos
        private List<ProductoQuicksort> productos;
        public FormQuicksort()
        {
            InitializeComponent();
            this.Load += FormQuicksort_Load;
            productos = new List<ProductoQuicksort>(); // Inicialización de la lista de productos
        }

        private void FormQuicksort_Load(object sender, EventArgs e)
        {
            // Llenar el ComboBox con las opciones de criterio
            cbCriterio.Items.Add("Codigo");
            cbCriterio.Items.Add("Nombre");
            cbCriterio.Items.Add("FechaIngreso");
            cbCriterio.Items.Add("FechaVencimiento");
            cbCriterio.Items.Add("PrecioCompra");
            cbCriterio.Items.Add("PrecioVenta");

            // Llenar el ComboBox con las categorías de productos
            cbcategoria.Items.Add("Bolsa 1 Lb");
            cbcategoria.Items.Add("Bolsa 2 Lb");
            cbcategoria.Items.Add("Paquete");
            cbcategoria.Items.Add("Vaso");
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            // Validar que no haya campos vacíos
            if (string.IsNullOrWhiteSpace(txtcodigo.Text) ||
                string.IsNullOrWhiteSpace(txtproducto.Text) ||
                string.IsNullOrWhiteSpace(txtdescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtpreciocompra.Text) ||
                string.IsNullOrWhiteSpace(txtprecioventa.Text) ||
                cbcategoria.SelectedItem == null)
            {
                // Mostrar mensaje de advertencia si hay algún campo vacío
                MessageBox.Show("Por favor, rellene todos los campos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (dtpfechavencimiento.Value <= dtpfechaingreso.Value)  // Verificar que la fecha de vencimiento sea mayor que la fecha de ingreso
            {
                MessageBox.Show("La fecha de vencimiento debe ser posterior a la fecha de ingreso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    // Agregar un nuevo producto a la lista (por ejemplo, usando los valores de los campos del formulario)
                    ProductoQuicksort nuevoProducto = new ProductoQuicksort
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

                    // Limpiar los campos de texto
                    LimpiarCampos();

                    // Actualizar el DataGridView
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
            // Eliminar el producto seleccionado
            if (dgvProducto.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow fila in dgvProducto.SelectedRows)
                {
                    if (!fila.IsNewRow)
                    {
                        productos.RemoveAt(fila.Index);
                    }
                }
                // Actualizar el DataGridView
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarDataGridView()
        {
            // Limpiar las filas del DataGridView
            dgvProducto.Rows.Clear();

            // Agregar los productos a las filas del DataGridView
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
            // Limpiar los campos de texto y controles
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
            // Verificar si la lista de productos está vacía
            if (productos.Count == 0)
            {
                MessageBox.Show("No hay productos para ordenar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir de la función si no hay productos
            }

            // Verificar si se ha seleccionado un criterio de ordenación
            if (cbCriterio.SelectedItem != null)
            {
                // Obtener el criterio de ordenación
                string criterio = cbCriterio.SelectedItem.ToString();

                // Llamar al método de ordenación para ordenar los productos de forma ascendente
                Quicksort.Ordenar(productos, criterio, true);

                // Refrescar el DataGridView
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un criterio de ordenación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDescendente_Click(object sender, EventArgs e)
        {
            // Verificar si la lista de productos está vacía
            if (productos.Count == 0)
            {
                MessageBox.Show("No hay productos para ordenar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir de la función si no hay productos
            }

            // Verificar si se ha seleccionado un criterio de ordenación
            if (cbCriterio.SelectedItem != null)
            {
                // Obtener el criterio de ordenación
                string criterio = cbCriterio.SelectedItem.ToString();

                // Llamar al método de ordenación para ordenar los productos de forma descendente
                Quicksort.Ordenar(productos, criterio, false);

                // Refrescar el DataGridView
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un criterio de ordenación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
