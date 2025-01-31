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
    public partial class UcRegistrarProduto : UserControl
    {
        public UcRegistrarProduto()
        {
            InitializeComponent();

            cmbUn.Items.Add("-");
            cmbUn.Items.Add("UN");
            cmbUn.Items.Add("KG");
            cmbUn.Items.Add("LT");
        }


        private void txbCodigo_TextChanged(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada não é um dígito e nem uma tecla de controle (como Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Se o caractere não for um dígito ou controle, cancela o evento, ou seja, ignora a entrada
                e.Handled = true;
            }
        }

        private void txbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Certifique-se de que apenas números, vírgulas, pontos ou teclas de controle podem ser digitadas
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                // Apenas um ponto ou vírgula decimal permitido
                if ((e.KeyChar == '.' || e.KeyChar == ',') && !(sender as TextBox).Text.Contains(".") || !(sender as TextBox).Text.Contains(","))
                {
                    e.Handled = true;
                }
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            InsereNovosProdutos();
        }

        public void InsereNovosProdutos()
        {

            MdProdutos mdProdutos = new MdProdutos();

            if (string.IsNullOrEmpty(txbCodigo.Text) || string.IsNullOrEmpty(txbNome.Text) || string.IsNullOrEmpty(txbDescricao.Text) ||
                string.IsNullOrEmpty(txbQtd.Text) || string.IsNullOrEmpty(txbPreco.Text))
            {

                MessageBox.Show("Todos os campos deve estar preenchidos, favor verificar!");
            }
            else
            {
                mdProdutos.Codigo = Convert.ToInt64(txbCodigo.Text);
                mdProdutos.Nome = txbNome.Text;
                mdProdutos.Descricao = txbDescricao.Text;
                mdProdutos.Quantidade = int.Parse(txbQtd.Text);
                mdProdutos.Valor = txbPreco.Text;
                mdProdutos.PrecoCusto = Convert.ToDouble(txbPrecoCusto.Text);
                mdProdutos.Porcentagem = int.Parse(txbPorcentagem.Text);
                mdProdutos.Quantidade = int.Parse(txbQtdAtual.Text);
                mdProdutos.TipoMedida = cmbUn.Text;



                if (mdProdutos.insert())
                {
                    MessageBox.Show("Produto Inserido com sucesso!");
                    txbCodigo.Clear();
                    txbNome.Clear();
                    txbDescricao.Clear();
                    txbQtd.Clear();
                    txbPreco.Clear();
                    txbPrecoCusto.Clear();
                    txbPorcentagem.Clear();
                    txbQtdAtual.Clear();
                }
                else
                {
                    MessageBox.Show("Falha ao inserir produto, favor procure o administrador do sistema!");
                }
            }

        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Certifique-se de que apenas números, vírgulas, pontos ou teclas de controle podem ser digitadas
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                // Apenas um ponto ou vírgula decimal permitido
                if ((e.KeyChar == '.' || e.KeyChar == ',') && !(sender as TextBox).Text.Contains(".") || !(sender as TextBox).Text.Contains(","))
                {
                    e.Handled = true;
                }
            }
        }

        private void txbPorcentagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Certifique-se de que apenas números, vírgulas, pontos ou teclas de controle podem ser digitadas
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                // Apenas um ponto ou vírgula decimal permitido
                if ((e.KeyChar == '.' || e.KeyChar == ',') && !(sender as TextBox).Text.Contains(".") || !(sender as TextBox).Text.Contains(","))
                {
                    e.Handled = true;
                }
            }
        }

        private void txbPorcentagem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((string.IsNullOrEmpty(txbPreco.Text) || txbPreco.Text == "") && (!string.IsNullOrEmpty(txbPorcentagem.Text) || txbPorcentagem.Text != ""))
                {
                    if (!string.IsNullOrEmpty(txbPrecoCusto.Text))
                    {
                        double precoCusto = Convert.ToDouble(txbPrecoCusto.Text);
                        double valor = precoCusto * (Convert.ToDouble(txbPorcentagem.Text) / 100);
                        double total = precoCusto + valor;
                        txbPreco.Text = total.ToString();
                    }
                }
            }
        }

        private void txbPreco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!(string.IsNullOrEmpty(txbPreco.Text) || txbPreco.Text == "") && !(!string.IsNullOrEmpty(txbPorcentagem.Text) || txbPorcentagem.Text != ""))
                {
                    if (!string.IsNullOrEmpty(txbPrecoCusto.Text))
                    {
                        double precoCusto = Convert.ToDouble(txbPrecoCusto.Text);
                        double porcentagem = ((Convert.ToDouble(txbPreco.Text) - precoCusto) / precoCusto) * 100;

                        txbPorcentagem.Text = porcentagem.ToString();
                    }
                }

            }                
        }
    }
}
