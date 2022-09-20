using AplicacaoPoo.Estrutural.Windows.Funcionalidades;

namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnDolar_Click(object sender, EventArgs e)
        {
            var form = new frmCotacaoDolar();
            form.Show();
        }

        private void btnComissao_Click(object sender, EventArgs e)
        {
            var form = new frmComissao();
            form.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }   
}