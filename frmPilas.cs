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
    public partial class frmPilas : Form
    {
        private Stack<Producto> pilaproductos = new Stack<Producto>();

        Stack<string> pilaProductos = new Stack<string>();

        public frmPilas()
        {
            InitializeComponent();
        }

        private void frmPilas_Load(object sender, EventArgs e)
        {
            this.txtcodigo.Focus();
            cbcategoria.Items.Add("Bolsa 1 Lb");
            cbcategoria.Items.Add("Bolsa 2 Lb");
            cbcategoria.Items.Add("Paquete");
            cbcategoria.Items.Add("Vaso");
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {

            Producto nuevoProducto = new Producto
            (
                txtcodigo.Text,
                textproducto.Text,
                txtdescripcion.Text,
                cbcategoria.Text,
                dtpfechaingreso.Value,
                dtpfechavencimiento.Value,
                Convert.ToDecimal(txtpreciocompra.Text),
                Convert.ToDecimal(txtprecioventa.Text)
            );

            pilaproductos.Push(nuevoProducto);


            string producto = textproducto.Text;
            if (!string.IsNullOrEmpty(producto))
            {
                pilaProductos.Push(producto);
                MessageBox.Show($"{producto} añadido a la pila.");
                
            }

            ActualizarInventario();
        }

        private void ActualizarInventario()
        {
            DataGridViewRow fila = new DataGridViewRow();

            fila.CreateCells(dgvProducto);
            fila.Cells[0].Value = txtcodigo.Text;
            fila.Cells[1].Value = textproducto.Text;
            fila.Cells[2].Value = txtdescripcion.Text;
            fila.Cells[3].Value = cbcategoria.Text;
            fila.Cells[4].Value = dtpfechaingreso.Text;
            fila.Cells[5].Value = dtpfechavencimiento.Text;
            fila.Cells[6].Value = txtpreciocompra.Text;
            fila.Cells[7].Value = txtprecioventa.Text;


            dgvProducto.Rows.Add(fila);

            txtcodigo.Text = "";
            textproducto.Text = "";
            txtdescripcion.Text = "";
            txtpreciocompra.Text = "";
            txtprecioventa.Text = "";
            dtpfechaingreso.Text = "";
            dtpfechavencimiento.Text = "";
            cbcategoria.Text = "";

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (pilaProductos.Count > 0)
            {

                string productoEliminado = pilaProductos.Pop();
                MessageBox.Show($"{productoEliminado} eliminado de la pila.");


                if (dgvProducto.Rows.Count > 0)
                {
                    dgvProducto.Rows.RemoveAt(dgvProducto.Rows.Count - 1);
                }
            }
            else
            {
                MessageBox.Show("La pila está vacía.");
            }
        }
        private void btnVU_Click(object sender, EventArgs e)
        {
            if (pilaProductos.Count > 0)
            {
                string ultimoProducto = pilaProductos.Peek();
                MessageBox.Show($"Último producto en la pila: {ultimoProducto}");
            }
            else
            {
                MessageBox.Show("La pila está vacía.");
            }
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

        private void btnAtras_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void cbcategoria_DropDownStyleChanged(object sender, EventArgs e)
        {

        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtproducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
