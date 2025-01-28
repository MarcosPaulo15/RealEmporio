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
    public partial class FoAcertarFracionado : Form
    {
        double total;
        int clientId;
        public FoAcertarFracionado(double valorTotal, int idCliente)
        {
            InitializeComponent();
            total = valorTotal;
            clientId = idCliente;
        }

        private void txbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void txbValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if(string.IsNullOrEmpty(txbValor.Text) || txbValor.Text == "")
                {
                    MessageBox.Show("Favor digite o valor que deve ser abatido");
                }
                else 
                { 
                    
                    string t = txbValor.Text;
                    double reduzidoConv = Convert.ToDouble(t);
                    if(reduzidoConv > total)
                    {
                        MessageBox.Show("Valor inserido, maior do que o valor total, favor inserir a quantidade correta ou voltar e abater o valor total!");
                    }
                    else
                    {
                        MdProdutos produtos = new MdProdutos();
                        double valorReduzido = total - reduzidoConv;
                        if(produtos.ReduzValorTotal(valorReduzido, clientId))
                        {
                            MessageBox.Show("VALOR ABATIDO, COM SUCESSO!");
                            UcVerClientes ver = new UcVerClientes();
                            Close();
                            ver.Initialize();                            
                        }
                    }                    
                }
            }
        }
    }
}
