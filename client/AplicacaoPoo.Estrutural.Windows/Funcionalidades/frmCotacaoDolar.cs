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


            var list = new List<string>();
            list.Add(MoedaHelper.Dolar);
            list.Add(MoedaHelper.Euro);
            list.Add(MoedaHelper.Libra);
            cmbMoeda.DataSource = list;
            cmbMoeda.SelectedIndex = 0;
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

        private void cmbMoeda_SelectedIndexChanged(object sender, EventArgs e)

        {
            if (txtValor.Text == "") return;
            var valor = decimal.Parse(txtValor.Text);
            var moedaService    =   new ConverterMoedaServices();   
            switch (cmbMoeda.SelectedValue)
            {

              case MoedaHelper.Dolar:
                    {
                     var valorConvertido = 
                         moedaService.ConverterDolarEmReal(valor);
                      lblPrimeiroValor.Text = $"{valor} {MoedaHelper.Dolar} igual a";
                      lblSegunddoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";

                        break;

                    }
              case MoedaHelper.Euro:
                    {
                    var valorConvertido =
                         moedaService.ConverterEuroEmReal(valor);
                        lblPrimeiroValor.Text = $"{valor} {MoedaHelper.Euro} igual a";
                        lblSegunddoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";

                        break;
                    }

              case MoedaHelper.Libra:
                    {
                     var valorConvertido =
                         moedaService.ConverterLibraEmReal(valor);
                        lblPrimeiroValor.Text = $"{valor} {MoedaHelper.Libra} igual a";
                        lblSegunddoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";

                        break;

                    }

            }
        }
    }
}

