using System.Windows.Forms.VisualStyles;

namespace ProyectoFinalEstructuraDatosGrupo4
{
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
