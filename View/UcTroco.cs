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
    public partial class UcTroco : UserControl
    {
        int idMax;
        public UcTroco(int id)
        {
            InitializeComponent();
            this.idMax = id;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            MdProdutos mdProdutos = new MdProdutos();
            if (e.KeyCode == Keys.Enter)
            {
                
                string i = mdProdutos.SomaTodosValores(idMax).Rows[0]["TOTAL"].ToString();
                double valor = double.Parse(i);
                double total = double.Parse(txbTotal.Text);
                if(total < valor)
                {
                    double troco = valor - total;
                    lblTroco.Text = Math.Round(troco, 2).ToString();
                }
                else
                {
                    double troco = total - valor;
                    lblTroco.Text = Math.Round(troco, 2).ToString();
                }
            }            
            else if (e.KeyCode == Keys.F4)
            {
                if (!string.IsNullOrEmpty(txbTotal.Text))
                {                    
                    //FoVendas2 foVendas2 = new FoVendas2(true);
                    MessageBox.Show("Compra tipo Dinheiro Concluida com sucesso!");
                    if(mdProdutos.InsereTipoVenda(idMax, '4'))
                    {
                        Form parentForm = this.FindForm();
                        if (parentForm != null)
                        {
                            parentForm.Close();
                        }
                        e.Handled = true;
                    }                   
                }
                else
                {
                    MessageBox.Show("FAVOR INSERIR VALOR RECEBIDO!");
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Certifique-se de que apenas números, vírgulas, pontos ou teclas de controle podem ser digitadas
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                // Apenas um ponto ou vírgula decimal permitido
                if ((e.KeyChar == '.' || e.KeyChar == ',') && (sender as TextBox).Text.Contains(".") || (sender as TextBox).Text.Contains(","))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
