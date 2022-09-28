using AplicacaoPoo.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacao.Windows
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
            var cliente = new Client();
            cliente.Nome = "Jeanderson Araujo";
            textNome.Text = cliente.Nome;
            textCPF.Text = "123.456.789.01";
                lblSaldoInicialValor.Text = "1000";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var credito = new Credito();
            

        }
    }
}
