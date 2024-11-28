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
    public partial class InterfazPrincipal : Form
    {
        public InterfazPrincipal()
        {
            InitializeComponent();
        }

        private void btnPilas_Click(object sender, EventArgs e)
        {
            frmPilas frmPilas = new frmPilas();

            frmPilas.Show();
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            frmcolas frmcolas = new frmcolas();

            frmcolas.Show();
        }

        private void btnColaCircular_Click(object sender, EventArgs e)
        {
            FormColaCircular formColaCircular = new FormColaCircular();

            formColaCircular.Show();
        }

        private void btnListaS_Click(object sender, EventArgs e)
        {
            FormListaSimple formListaSimple = new FormListaSimple();

            formListaSimple.Show();
        }

        private void btnListaD_Click(object sender, EventArgs e)
        {
            FormListaDoble formListaDoble = new FormListaDoble();

            formListaDoble.Show();
        }

        private void btnQuick_Click(object sender, EventArgs e)
        {
            FormQuicksort formQuicksort = new FormQuicksort();

            formQuicksort.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormArbolBinario formArbolBinario = new FormArbolBinario();

            formArbolBinario.Show();
        }
    }
}
