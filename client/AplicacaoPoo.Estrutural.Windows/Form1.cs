using AplicacaoPoo.Estrutural.Windows.Funcionalidades;

namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDolar_Click(object sender, EventArgs e)
        {
            var form = new Form01();
            form.Show();
        }

        private void btnComissao_Click(object sender, EventArgs e)
        {
            var form = new Form02();
            form.Show();
        }
    }   
}