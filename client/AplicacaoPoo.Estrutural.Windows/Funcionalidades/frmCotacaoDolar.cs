using AplicacaoPoo.Dominio.services;
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
        private bool CotacaoEhValido;
        private bool ValorEmDolarEhValido;
        public frmCotacaoDolar()
        {
            InitializeComponent();
            btnCalcular.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var valor = decimal.Parse(txtValor.Text);

            var moeda = new ConverterMoedaServices();
            var resultado = moeda.ConverterDolarEmReal(valor);

            //string interpolation
            MessageBox.Show($"Valor convertido em real é: R$ {resultado}");
        }


        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtValor.Text == "") 
                {
                    btnCalcular.Enabled=false;
                    return;
                };
                var resultado = decimal.Parse(txtValor.Text);

                btnCalcular.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("A cotação do dolar é um valor decimal");
                txtValor.Focus();
                btnCalcular.Enabled = false;

            }

        }
    }
}

