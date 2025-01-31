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
    public partial class FoAtualizaProd : Form
    {
        MdProdutos produtos = new MdProdutos();
        string id = "";
        public FoAtualizaProd(string codigo)
        {
            InitializeComponent();
            id = codigo;
            Initialize();
        }

        public void Initialize()
        {
            if (produtos.ListaProdutosAlterarProd(id).Rows.Count > 0)
            {
                txbCodigo.Text = produtos.ListaProdutosAlterarProd(id).Rows[0]["CODIGO"].ToString();
                txbNome.Text = produtos.ListaProdutosAlterarProd(id).Rows[0]["NOME"].ToString();
                txbPrecoCusto.Text = produtos.ListaProdutosAlterarProd(id).Rows[0]["PRECO_CUSTO"].ToString();
                txbPreco.Text = produtos.ListaProdutosAlterarProd(id).Rows[0]["VALOR"].ToString();
                txbPorcentagem.Text = produtos.ListaProdutosAlterarProd(id).Rows[0]["PORCENTAGEM"].ToString();
                txbQtd.Text = produtos.ListaProdutosAlterarProd(id).Rows[0]["QUANTIDADE_MINIMA"].ToString();
                txbQtdAtual.Text = produtos.ListaProdutosAlterarProd(id).Rows[0]["QUANTIDADE_ATUAL"].ToString();
                txbDescricao.Text = produtos.ListaProdutosAlterarProd(id).Rows[0]["DESCRICAO"].ToString();
            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string t = txbCodigo.Text;
            string h = txbNome.Text;
            string k = txbDescricao.Text;
            int QuantidadeMin = txbQtd.Text == "" ? 0 : int.Parse(txbQtd.Text);
            string precoCusto = txbPrecoCusto.Text == "" ? "0.00" : txbPrecoCusto.Text.Replace(",", ".");
            //double precoCusto = txbPrecoCusto.Text == "" ? 0.00 : Convert.ToDouble(l);
            string preco = txbPreco.Text == "" ? "0.00" : txbPreco.Text.Replace(",", ".");
            //double preco = txbPreco.Text == "" ? 0.00 : Convert.ToDouble(j);
            string m = txbPorcentagem.Text.Replace(',', '.');
            string porcentagem = txbPorcentagem.Text == "" ? "0" : m;
            int quantidadeAtual = txbQtdAtual.Text == "" ? 0 : int.Parse(txbQtdAtual.Text);

            if (produtos.AtualizarProdutos(txbCodigo.Text, txbNome.Text, txbDescricao.Text, QuantidadeMin, precoCusto, preco, porcentagem, quantidadeAtual, id))
            {
                MessageBox.Show("Atualizado com Sucesso");
                Hide();
                UcAtualizarEstoque uc = new UcAtualizarEstoque();
                uc.Initialize();

            }
            else
            {
                MessageBox.Show("Erro ao atualizar, favor procure o administrador do sistema!");
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

        private void txbPreco_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txbQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void txbQtdAtual_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }
    }
}
