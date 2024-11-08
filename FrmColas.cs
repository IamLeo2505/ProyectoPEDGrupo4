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
    public partial class frmcolas : Form
    {
        private Queue<Producto> colaProductos = new Queue<Producto>();

        public frmcolas()
        {
            InitializeComponent();
        }

        private void frmcolas_Load(object sender, EventArgs e)
        {
            this.txtcodigo.Focus();
        }

        private void ActualizarDataGridView()
        {
            dgvProducto.Rows.Clear();

            foreach (var producto in colaProductos)
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
            textproducto.Clear();
            txtdescripcion.Clear();
            cbcategoria.SelectedIndex = -1; 
            dtpfechaingreso.Value = DateTime.Now;
            dtpfechavencimiento.Value = DateTime.Now;
            txtpreciocompra.Clear();
            txtprecioventa.Clear();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                Producto nuevoProducto = new Producto(
                    txtcodigo.Text,
                    textproducto.Text,
                    txtdescripcion.Text,
                    cbcategoria.Text,
                    dtpfechaingreso.Value,
                    dtpfechavencimiento.Value,
                    Convert.ToDecimal(txtpreciocompra.Text),
                    Convert.ToDecimal(txtprecioventa.Text)
                );

                colaProductos.Enqueue(nuevoProducto);
                MessageBox.Show("Producto añadido a la cola.");
                ActualizarDataGridView();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al añadir el producto: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (colaProductos.Count > 0)
            {
                Producto productoEliminado = colaProductos.Dequeue();
                MessageBox.Show($"Producto eliminado: {productoEliminado.NombreProducto}");
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("La cola está vacía. No se puede eliminar.");
            }


        }

        private void btnVerFrente_Click(object sender, EventArgs e)
        {

            if (colaProductos.Count > 0)
            {
                Producto productoFrente = colaProductos.Peek();
                MessageBox.Show($"Frente de la cola: {productoFrente.NombreProducto}");
            }
            else
            {
                MessageBox.Show("La cola está vacía.");
            }

        }

        private void btnVerUltimo_Click(object sender, EventArgs e)
        {
            if (colaProductos.Count > 0)
            {
                Producto productoUltimo = colaProductos.Last();
                MessageBox.Show($"Último en la cola: {productoUltimo.NombreProducto}");
            }
            else
            {
                MessageBox.Show("La cola está vacía.");
            }
        }

        private void btnColaVacia_Click(object sender, EventArgs e)
        {
            int cantidad = colaProductos.Count;

            if (cantidad == 0)
            {
                MessageBox.Show("La cola está vacía.");
            }
            else
            {

                MessageBox.Show($"La cola tiene {cantidad} producto(s).\n");
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                    this.txtcodigo.Focus();
                }
                if (c is ComboBox)
                {
                    c.Text = "";
                }
            }
        }
    }
}

