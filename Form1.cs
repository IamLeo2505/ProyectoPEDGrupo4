using System.Windows.Forms.VisualStyles;

namespace ProyectoFinalEstructuraDatosGrupo4
{
    public partial class Form1 : Form
    public partial class InterfazPrincipal : Form
    {
        public Form1()
        public InterfazPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void btnPilas_Click(object sender, EventArgs e)
        {
            frmPilas pilasForm = new frmPilas();
            pilasForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormColaCircular ColaCircularForm = new FormColaCircular();
            ColaCircularForm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormQuicksort QuicksortForm = new FormQuicksort();
            QuicksortForm.Show();
        }

        private void button11_Click(object sender, EventArgs e, FormListaSimple ListaSimpleForm)
        {
            ListaSimpleForm.Show();
        }

        private void btncolas_Click(object sender, EventArgs e)
        {
            frmcolas ColaForm = new frmcolas();
            ColaForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnlistaenlazada_Click(object sender, EventArgs e)
        {
           
        }

        private void btnlistaenlazada_Click_1(object sender, EventArgs e)
        {
            FormListaDoble listaDoble = new FormListaDoble();
            listaDoble.Show();
        }

        private void btnColaCircular_Click(object sender, EventArgs e)
        {
            FormColaCircular formColaCircular = new FormColaCircular();
            formColaCircular.Show();
        }

        private void btnLD_Click(object sender, EventArgs e)
        {
            FrmListaDoble formListaDoble = new FrmListaDoble();
            formListaDoble.Show();
        }
    }
}
