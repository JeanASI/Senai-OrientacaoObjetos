using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Estrutural.Windows.Funcionalidades
{
    public partial class frmCotacaoDolar : Form
    {
        public frmCotacaoDolar()
        {
            InitializeComponent();
            btnCalcular.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var dolar = decimal.Parse(txtDolar.Text);
            var valor = decimal.Parse(txtValor.Text);
            var resultado = valor * dolar;
            MessageBox.Show("Valor convertido em real é" + resultado);
        }

        private void txtDolar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var resultado = decimal.Parse(txtDolar.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("A cotação do dolar é um valor decimal");
                txtDolar.Focus();

                throw;
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var resultado = decimal.Parse(txtValor.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("A cotação do dolar é um valor decimal");
                txtDolar.Focus();

                throw;
            }

        }
    }
}
