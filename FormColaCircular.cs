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
    public partial class FormColaCircular : Form
    {
        private ColaCircular colaProductos;

        public FormColaCircular()
        {
            InitializeComponent();
            colaProductos = new ColaCircular(10);
            this.Load += FormColaCircular_Load;
        }

        private void FormColaCircular_Load(object sender, EventArgs e)
        {
            cbcategoria.Items.Add("Bolsa 1 Lb");
            cbcategoria.Items.Add("Bolsa 2 Lb");
            cbcategoria.Items.Add("Paquete");
            cbcategoria.Items.Add("Vaso");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Validar que no haya campos vacíos
            if (string.IsNullOrWhiteSpace(txtcodigo.Text) ||
                string.IsNullOrWhiteSpace(txtproducto.Text) ||
                string.IsNullOrWhiteSpace(txtdescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtprecioventa.Text) ||
                string.IsNullOrWhiteSpace(txtpreciocompra.Text) ||
                cbcategoria.SelectedItem == null)
            {
                // Mostrar mensaje de advertencia si hay algún campo vacío
                MessageBox.Show("Por favor, rellene todos los campos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    ProductoColasCirculares nuevoProducto = new ProductoColasCirculares
                    (
                        txtcodigo.Text,
                        txtproducto.Text,
                        txtdescripcion.Text,
                        cbcategoria.SelectedItem.ToString(),
                        dtpfechaingreso.Value,
                        dtpfechavencimiento.Value,
                        Convert.ToDecimal(txtprecioventa.Text),
                        Convert.ToDecimal(txtpreciocompra.Text)
                    );
                    colaProductos.Añadir(nuevoProducto);
                    MessageBox.Show($"{nuevoProducto.NombreProducto} añadido a la cola.");
                    ActualizarInventario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoColasCirculares productoEliminado = colaProductos.Eliminar();
                MessageBox.Show($"{productoEliminado.NombreProducto} eliminado de la cola.");
                ActualizarInventario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerInicio_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoColasCirculares productoFrente = colaProductos.VerFrente();
                MessageBox.Show($"Producto en el frente de la cola: {productoFrente.NombreProducto}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerFinal_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoColasCirculares productoFinal = colaProductos.VerFinal();
                MessageBox.Show($"Producto al final de la cola: {productoFinal.NombreProducto}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarInventario()
        {
            dgvProducto.Rows.Clear();
            List<ProductoColasCirculares> productos = colaProductos.ObtenerElementos();

            foreach (var producto in productos)
            {
                dgvProducto.Rows.Add(new object[]
                {
                    producto.Codigo,
                    producto.NombreProducto,
                    producto.Descripcion,
                    producto.Categoria,
                    producto.FechaIngreso.ToShortDateString(),
                    producto.FechaVencimiento.ToShortDateString(),
                    producto.PrecioCompra,
                    producto.PrecioVenta
                });
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormColaCircular_Load_1(object sender, EventArgs e)
        {

        }
    }
}
