using AplicacaoPoo.Dominio.Helpers;
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
    public partial class frmComissao : Form
    {
        public frmComissao()
        {
            InitializeComponent();
            lblComissao.Text = "resultado";
            int quantVendida = 0;
            quantVendida = txtQuantidadeVendida.Text;
            double precoUnitario = 0,  resultado = 0;
            precoUnitario = txtPrecoDaPeca.Text;
            resultado = (quantVendida * precoUnitario)  / 0.05;
        }
    }
}
