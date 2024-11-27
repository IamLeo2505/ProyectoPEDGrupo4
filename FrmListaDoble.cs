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
    public partial class FrmListaDoble : Form
    {
        ListaDobleEnlazada listaDobleProductos = new ListaDobleEnlazada();

        public FrmListaDoble()
        {
            InitializeComponent();
        }

        private void FrmListaDoble_Load(object sender, EventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Producto nuevoProducto = new Producto(
             txtcodigo.Text,
             textproducto.Text,
             txtdescripcion.Text,
             cbcategoria.SelectedItem?.ToString(),
             dtpfechaingreso.Value,
             dtpfechavencimiento.Value,
             decimal.Parse(txtpreciocompra.Text),
             decimal.Parse(txtprecioventa.Text)
            );

            listaDobleProductos.AgregarProducto(nuevoProducto);
            MessageBox.Show("Producto agregado correctamente.");
            ActualizarDataGridView();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string codigo = txtcodigo.Text;

            if (listaDobleProductos.EliminarProducto(codigo))
            {
                MessageBox.Show("Producto eliminado correctamente.");
                ActualizarDataGridView();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string codigo = txtcodigo.Text;

            Producto productoEditado = new Producto(
                txtcodigo.Text,
                textproducto.Text,
                txtdescripcion.Text,
                cbcategoria.Text,
                dtpfechaingreso.Value,
                dtpfechavencimiento.Value,
                decimal.Parse(txtpreciocompra.Text),
                decimal.Parse(txtprecioventa.Text)
            );

            if (listaDobleProductos.EditarProducto(codigo, productoEditado))
            {
                MessageBox.Show("Producto editado correctamente.");
                ActualizarDataGridView();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        private void ActualizarDataGridView()
        {
            dgvProducto.Rows.Clear();
            List<Producto> productos = listaDobleProductos.ObtenerProductos();

            foreach (Producto producto in productos)
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
        private void dgvProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Obtener el índice de la fila editada
                int rowIndex = e.RowIndex;

                // Obtener los valores de la fila editada
                string codigo = dgvProducto.Rows[rowIndex].Cells["codigo"].Value.ToString();
                string nombreProducto = dgvProducto.Rows[rowIndex].Cells["nombreproducto"].Value.ToString();
                string descripcion = dgvProducto.Rows[rowIndex].Cells["descripcion"].Value.ToString();
                string categoria = dgvProducto.Rows[rowIndex].Cells["categoria"].Value.ToString();
                DateTime fechaIngreso = Convert.ToDateTime(dgvProducto.Rows[rowIndex].Cells["fechaingreso"].Value);
                DateTime fechaVencimiento = Convert.ToDateTime(dgvProducto.Rows[rowIndex].Cells["fechavencimiento"].Value);
                decimal precioCompra = Convert.ToDecimal(dgvProducto.Rows[rowIndex].Cells["preciocompra"].Value);
                decimal precioVenta = Convert.ToDecimal(dgvProducto.Rows[rowIndex].Cells["precioventa"].Value);

                // Crear el nuevo producto editado
                Producto productoEditado = new Producto(
                    codigo,
                    nombreProducto,
                    descripcion,
                    categoria,
                    fechaIngreso,
                    fechaVencimiento,
                    precioCompra,
                    precioVenta
                );

                // Editar el producto en la lista enlazada doble
                if (listaDobleProductos.EditarProducto(codigo, productoEditado))
                {
                    MessageBox.Show("Producto editado correctamente en la lista.");
                }
                else
                {
                    MessageBox.Show("Error al editar el producto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar la celda: {ex.Message}");
            }
        }


        private void LimpiarCampos()
        {
            txtcodigo.Clear();
            textproducto.Clear();
            txtdescripcion.Clear();
            cbcategoria.SelectedIndex = -1;
            dtpfechaingreso.Value = DateTime.Now;
            dtpfechavencimiento.Value = DateTime.Now;
            txtpreciocompra.Clear();
            txtprecioventa.Clear();
        }

    }
}
