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
    public partial class FormArbolBinario : Form
    {
        private List<ProductoColasCirculares> productos;
        private ArbolBinario arbolBinario = new ArbolBinario();
        public FormArbolBinario()
        {
            InitializeComponent();
            this.Load += FormArbolBinario_Load;
            productos = new List<ProductoColasCirculares>();
        }

        private void FormArbolBinario_Load(object sender, EventArgs e)
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

            ProductoColasCirculares producto = new ProductoColasCirculares
            {
                Codigo = txtcodigo.Text,
                NombreProducto = txtproducto.Text,
                Descripcion = txtdescripcion.Text,
                Categoria = cbcategoria.Text,
                FechaIngreso = dtpfechaingreso.Value,
                FechaVencimiento = dtpfechavencimiento.Value,
                PrecioCompra = precioCompra,
                PrecioVenta = precioVenta
            };

            arbolBinario.Insertar(producto);
            List<ProductoColasCirculares> productos = new List<ProductoColasCirculares>();
            arbolBinario.RecorrerEnOrden(arbolBinario.Raiz, p => productos.Add(p));
            MostrarProductos(productos);
            LimpiarCampos();
            MessageBox.Show("Producto agregado al árbol binario.");
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
                        bool eliminado = arbolBinario.Eliminar(codigoProducto);

                        if (eliminado)
                        {
                            MessageBox.Show("Producto eliminado del árbol binario.");
                            List<ProductoColasCirculares> productos = new List<ProductoColasCirculares>();
                            arbolBinario.RecorrerEnOrden(arbolBinario.Raiz, p => productos.Add(p));
                            MostrarProductos(productos);
                        }
                        else
                        {
                            MessageBox.Show("Producto no encontrado en el árbol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtcodigo.Text;

            ProductoColasCirculares producto = arbolBinario.Buscar(codigo);

            if (producto == null)
            {
                MessageBox.Show("Producto no encontrado");
            }
        }

        private void btnAscendente_Click(object sender, EventArgs e)
        {
            if (arbolBinario.Raiz == null)
            {
                MessageBox.Show("El árbol binario está vacío.");
                return;
            }
            else
            {

                List<ProductoColasCirculares> productos = new List<ProductoColasCirculares>();
                arbolBinario.RecorrerEnOrden(arbolBinario.Raiz, producto =>
                {
                    productos.Add(producto);
                });

                MostrarProductos(productos);
            }
        }

        private void MostrarProductos(List<ProductoColasCirculares> productos)
        {
            dgvProducto.Rows.Clear();
            foreach (var producto in productos)
            {
                dgvProducto.Rows.Add(
                    producto.Codigo,
                    producto.NombreProducto,
                    producto.Descripcion,
                    producto.Categoria,
                    producto.FechaIngreso.ToShortDateString(),
                    producto.FechaVencimiento.ToShortDateString(),
                    producto.PrecioCompra,
                    producto.PrecioVenta);
            }
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

        private void btnDescendente_Click(object sender, EventArgs e)
        {
            if (arbolBinario.Raiz == null)
            {
                MessageBox.Show("El árbol binario está vacío.");
                return;
            }
            else
            {
                List<ProductoColasCirculares> productos = new List<ProductoColasCirculares>();
                arbolBinario.RecorrerEnOrden(arbolBinario.Raiz, producto =>
                {
                    productos.Add(producto);
                });

                productos.Reverse();
                MostrarProductos(productos);
            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
