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
    public partial class UcVerClientes : UserControl
    {
        MdProdutos produtos = new MdProdutos();
        MdNovoClient client = new MdNovoClient();
        double total;
        int clientId;


        public UcVerClientes()
        {
            InitializeComponent();
            Initialize();

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            dgvDebitos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            buttonColumn.HeaderText = "quitar";
            buttonColumn.Name = "Ação";  // Certifique-se de definir o nome da coluna
            buttonColumn.Text = "Acertar";
            buttonColumn.UseColumnTextForButtonValue = true;
            dgvDebitos.Columns.Add(buttonColumn);

            DataGridViewButtonColumn btnParte = new DataGridViewButtonColumn();
            dgvDebitos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnParte.HeaderText = "fracionado";
            btnParte.Name = "parte";  // Certifique-se de definir o nome da coluna
            btnParte.Text = "Acertar Fracionado";
            btnParte.UseColumnTextForButtonValue = true;
            dgvDebitos.Columns.Add(btnParte);
        }

        public void Initialize()
        {
            client.CarregaListaCompletaDebitos();
            dgvDebitos.DataSource = client.CarregaListaCompletaDebitos();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txbSearch.Text) || txbSearch.Text.Length == 0)
            {
                Initialize();
            }
            else
            {
               dgvDebitos.DataSource = client.FiltraDebitoCliente(txbSearch.Text);
            }
        }

        private void dgvDebitos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifique se a coluna "Ação" existe e se o índice da coluna está correto
            if (e.ColumnIndex == dgvDebitos.Columns["Ação"].Index && e.RowIndex >= 0)
            {
                int idProd = Convert.ToInt32(dgvDebitos.Rows[e.RowIndex].Cells["ID"].Value);
                if (produtos.AtualizaSituacaoCli(idProd))
                {
                    FoObservacao foObservacao = new FoObservacao(idProd);
                    foObservacao.TopMost = true;
                    foObservacao.ShowDialog();
                    foObservacao.Focus();
                    Initialize();
                }
            }

            else if (e.ColumnIndex == dgvDebitos.Columns["parte"].Index && e.RowIndex >= 0)
            {
                txbValor.Visible = true;
                lblValor.Visible = true;
                double valorTotal = Convert.ToDouble(dgvDebitos.Rows[e.RowIndex].Cells["VALOR_TOTAL"].Value);
                total = valorTotal;
                int idCliente = Convert.ToInt32(dgvDebitos.Rows[e.RowIndex].Cells["ID"].Value);
                clientId = idCliente;
                /*FoAcertarFracionado fracionado = new FoAcertarFracionado(valorTotal, idCliente);
                fracionado.ShowDialog();*/
            }
        }

        private void txbValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (string.IsNullOrEmpty(txbValor.Text) || txbValor.Text == "")
                {
                    MessageBox.Show("Favor digite o valor que deve ser abatido");
                }
                else
                {

                    string t = txbValor.Text;
                    double reduzidoConv = Convert.ToDouble(t);
                    if (reduzidoConv > total)
                    {
                        MessageBox.Show("Valor inserido, maior do que o valor total, favor inserir a quantidade correta ou voltar e abater o valor total!");
                    }
                    else
                    {
                        MdProdutos produtos = new MdProdutos();
                        double valorReduzido = total - reduzidoConv;
                        if (produtos.ReduzValorTotal(valorReduzido, clientId))
                        {
                            MessageBox.Show("VALOR ABATIDO, COM SUCESSO!");
                            lblValor.Visible = false;
                            txbValor.Visible = false;
                            Initialize();
                        }
                    }
                }
            }
        }

        private void txbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                // Apenas um ponto ou vírgula decimal permitido
                if ((e.KeyChar != '.' || e.KeyChar != ',') && !(sender as TextBox).Text.Contains(".") || !(sender as TextBox).Text.Contains(","))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
