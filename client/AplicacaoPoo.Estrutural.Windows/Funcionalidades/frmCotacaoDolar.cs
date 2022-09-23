using AplicacaoPoo.Dominio.Helpers;
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
       
        public frmCotacaoDolar()
        {
            InitializeComponent();
            lblPrimeiroValor.Text = $"1 {MoedaHelper.Dolar} igual a";
            lblSegunddoValor.Text = $"5,12 {MoedaHelper.Real}";
        }
        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtValor.Text == "") return;
         
                var valor = decimal.Parse(txtValor.Text);

                var moeda = new ConverterMoedaServices();
                var resultado = moeda.ConverterDolarEmReal(valor);
                lblPrimeiroValor.Text = $"{valor} {MoedaHelper.Dolar} igual a";
                lblSegunddoValor.Text = $"{resultado} {MoedaHelper.Real}";

            }
            catch (Exception)
            {
                MessageBox.Show("A cotação do dolar é um valor decimal");
                txtValor.Focus();

            }

        }
    }
}

