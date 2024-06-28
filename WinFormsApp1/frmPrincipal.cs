using Exercicio1;

namespace WinFormsApp1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmUsuarios().ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new frmChamados().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
