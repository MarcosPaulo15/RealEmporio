using EmporioRoyal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmporioRoyal.View
{
    public partial class FoVendas2 : Form
    {
        public FoVendas2()
        {
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                if (string.IsNullOrEmpty(txbCodigoBarras.Text))
                {
                    MessageBox.Show("Favor inserir codigo de barras para consulta"); 
                }
                else
                {

                    long codigo = Convert.ToInt64(txbCodigoBarras.Text);
                    MdProdutos produto = new MdProdutos();
                    if (produto.ProcurarProduto(codigo).Rows.Count > 0)
                    {
                        string nomeProduto = produto.ProcurarProduto(codigo).Rows[0]["NOME"].ToString();
                        string valor = produto.ProcurarProduto(codigo).Rows[0]["VALOR"].ToString();
                        string codigoBarras = produto.ProcurarProduto(codigo).Rows[0]["CODIGO"].ToString();
                        lblProduto.Text =  nomeProduto;
                        lblValUnitarioVal.Text = "R$ " + valor;
                        lblCodigoValores.Text = codigoBarras;
                    }
                }
            }
        }
    }
}
