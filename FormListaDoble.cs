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
using ProyectoFinalEstructuraDatosGrupo4.Modelos;

namespace ProyectoFinalEstructuraDatosGrupo4
{
    public partial class FormListaDoble : Form
    {

        ListaDoble listaInventario = new ListaDoble();

        public FormListaDoble()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            codigo.Clear();
            productname.Clear();
            descripcion.Clear();
            categoria.SelectedIndex = -1;
            ingreso.Value = DateTime.Now;
            vencimiento.Value = DateTime.Now;
            compra.Clear();
            venta.Clear();
        }


        private void ActualizarTabla()
        {
            dataGridView1.Rows.Clear();
            var nodos = listaInventario.ObtenerTodos();

            foreach (var nodo in nodos)
            {
                dataGridView1.Rows.Add(
                    nodo.Codigo,
                    nodo.Nombre,
                    nodo.Descripcion,
                    nodo.Categoria,
                    nodo.FechaIngreso.ToShortDateString(),
                    nodo.FechaVencimiento.ToShortDateString(),
                    nodo.PrecioCompra,
                    nodo.PrecioVenta
                );
            }
        }


        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string code = codigo.Text;

            if (!string.IsNullOrEmpty(code))
            {
                listaInventario.Eliminar(code);
                ActualizarTabla();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese el código del producto a eliminar.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void FormListaDoble_Load(object sender, EventArgs e)
        {

        }

        private void añadir_Click(object sender, EventArgs e)
        {
            ProyectoFinalEstructuraDatosGrupo4.Modelos.NodoDoble nuevoNodo = new ProyectoFinalEstructuraDatosGrupo4.Modelos.NodoDoble(
           codigo.Text,
           productname.Text,
           descripcion.Text,
           categoria.Text,
           ingreso.Value,
           vencimiento.Value,
           decimal.Parse(compra.Text),
           decimal.Parse(venta.Text)
           );

            listaInventario.InsertarAlFinal(nuevoNodo);
            ActualizarTabla();
            LimpiarCampos();
        }
    }
}
