using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoFinalEstructuraDatosGrupo4
{
    public partial class FormArbolBinario : Form
    {
        public class Nodo
        {
            public int Valor;
            public Nodo Izquierdo;
            public Nodo Derecho;

            public Nodo(int valor)
            {
                Valor = valor;
                Izquierdo = null;
                Derecho = null;
            }
        }

        private ArbolBinario arbol;

        public FormArbolBinario()
        {
            InitializeComponent();
            arbol = new ArbolBinario();
            txtcodigo.KeyPress += Numeros_KeyPress;
            txtprecioventa.KeyPress += Numeros_KeyPress;
            txtpreciocompra.KeyPress += Numeros_KeyPress;
            txtproducto.KeyPress += Letras_KeyPress;
            txtdescripcion.KeyPress += Letras_KeyPress;
        }
        private void Numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Letras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public class ArbolBinario
        {
            public Nodo Raiz;

            public ArbolBinario()
            {
                Raiz = null;
            }

            public void Insertar(int valor)
            {
                Raiz = InsertarRecursivo(Raiz, valor);
            }

            private Nodo InsertarRecursivo(Nodo raiz, int valor)
            {
                if (raiz == null)
                {
                    return new Nodo(valor);
                }

                if (valor < raiz.Valor)
                {
                    raiz.Izquierdo = InsertarRecursivo(raiz.Izquierdo, valor);
                }
                else if (valor > raiz.Valor)
                {
                    raiz.Derecho = InsertarRecursivo(raiz.Derecho, valor);
                }

                return raiz;
            }


            public void Dibujar(Graphics g, Nodo nodo, int x, int y, int offset)
            {

                if (nodo == null) return;


                g.FillEllipse(Brushes.LightBlue, x, y, 30, 30);
                g.DrawString(nodo.Valor.ToString(), new Font("Arial", 10), Brushes.Black, x + 10, y + 10);


                if (nodo.Izquierdo != null)
                {
                    g.DrawLine(Pens.Black, x + 15, y + 30, x - offset + 15, y + 60);
                    Dibujar(g, nodo.Izquierdo, x - offset, y + 60, offset / 2);
                }
                if (nodo.Derecho != null)
                {
                    g.DrawLine(Pens.Black, x + 15, y + 30, x + offset + 15, y + 60);
                    Dibujar(g, nodo.Derecho, x + offset, y + 60, offset / 2);
                }
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


        private void btnAñadir_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
            panel1.Invalidate();
            arbol = new ArbolBinario();


            InsertarValores();


            panel1.Invalidate();

        }
        private void InsertarValores()
        {
            if (int.TryParse(txtcodigo.Text, out int val1)) arbol.Insertar(val1);
            if (int.TryParse(txtproducto.Text, out int val2)) arbol.Insertar(val2);
            if (int.TryParse(txtdescripcion.Text, out int val4)) arbol.Insertar(val4);
            if (int.TryParse(txtpreciocompra.Text, out int val7)) arbol.Insertar(val7);
            if (int.TryParse(txtprecioventa.Text, out int val8)) arbol.Insertar(val8);
            if (int.TryParse(cbcategoria.Text, out int val3)) arbol.Insertar(val3);


            if (int.TryParse(dtpfechaingreso.Value.Year.ToString(), out int valDate1))
                arbol.Insertar(valDate1);
            if (int.TryParse(dtpfechavencimiento.Value.Year.ToString(), out int valDate2))
                arbol.Insertar(valDate2);
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            arbol.Dibujar(e.Graphics, arbol.Raiz, panel1.Width / 2, 20, 40);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
