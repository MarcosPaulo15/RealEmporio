using EmporioRoyal.Model;
using Microsoft.VisualBasic.ApplicationServices;
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
        int idMax;
        string nome = string.Empty;
        int usuarioID;
        bool teste = false; 
        public FoVendas2()
        {
            InitializeComponent();
            //Initialize();
        }

        public FoVendas2(int id, int idUsuario)
        {
            InitializeComponent();
            //Initialize(id);
            idMax = id;
            usuarioID = idUsuario;

            Initialize();
        }

        public FoVendas2(bool fecha)
        {
            if (fecha)
                Close();
        }
        public void Initialize()
        {
            MdProdutos mdProdutos = new MdProdutos();
            dgvListaProdutos.DataSource = mdProdutos.CarregaListaVendas(idMax); ;
            dgvListaProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
            MdProdutos mdProdutos = new MdProdutos();

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
                        lblProduto.Text = nomeProduto;
                        lblValUnitarioVal.Text = "R$ " + valor;
                        lblCodigoValores.Text = codigoBarras;

                        if (produto.InserirProdutosVendas(idMax, codigo, usuarioID))
                        {
                            if (produto.CarregaListaVendas(idMax).Rows.Count > 0)
                            {

                                dgvListaProdutos.DataSource = produto.CarregaListaVendas(idMax);
                                dgvListaProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                                if (produto.SomaTodosValores(idMax).Rows.Count > 0)
                                {
                                    // string valorTotal = produto.SomaTodosValores(idMax).Rows[0]["TOTAL"].ToString();
                                    //lblSubTotalVal.Text = "R$" + valorTotal + ",00";
                                    lblSubTotalVal.Text = "R$ " + produto.SomaTodosValores(idMax).Rows[0]["TOTAL"].ToString();
                                    txbCodigoBarras.Clear();
                                    if (!produto.AtualizaEstoque(codigo))
                                    {
                                        MessageBox.Show("Falha ao dar baixa no estoque, Favor procure o administrador do Sistema!");
                                    }
                                }
                            }


                        }
                    }
                    else
                    {
                        MessageBox.Show("CODIGO DE BARRAS INVALIDO, FAVOR DIGITE UM CODIGO VALIDO");
                    }
                }

            }
            if (e.KeyCode == Keys.F1)
            {

                if (mdProdutos.InsereTipoVenda(idMax, '1', usuarioID, '0', '0', "0"))
                {
                    MessageBox.Show("Compra tipo crédito Concluida com sucesso!");
                    Form parentForm = this.FindForm();
                    if (parentForm != null)
                    {
                        parentForm.Close();
                    }
                    e.Handled = true;
                }
                else
                {
                    MessageBox.Show("Erro ao inserir a compra, favor procure o administrador do sistema!");
                }

            }
            else if (e.KeyCode == Keys.F2)
            {

                if (mdProdutos.InsereTipoVenda(idMax, '2', usuarioID, '0', '0', "0"))
                {
                    MessageBox.Show("Compra tipo Débito Concluida com sucesso!");
                    Form parentForm = this.FindForm();
                    if (parentForm != null)
                    {
                        parentForm.Close();
                    }
                    e.Handled = true;
                }
                else
                {
                    MessageBox.Show("Erro ao inserir a compra, favor procure o administrador do sistema!");
                }

            }

            else if (e.KeyCode == Keys.F3)
            {

                if (mdProdutos.InsereTipoVenda(idMax, '3', usuarioID, '0', '0', "0"))
                {
                    MessageBox.Show("Compra tipo Pix Concluida com sucesso!");
                    Form parentForm = this.FindForm();
                    if (parentForm != null)
                    {
                        parentForm.Close();
                    }
                    e.Handled = true;
                }
                else
                {
                    MessageBox.Show("Erro ao inserir a compra, favor procure o administrador do sistema!");
                }

            }

            if (e.KeyCode == Keys.F4)
            {
                var myControl = new UcTroco(idMax, usuarioID);
                panel11.Controls.Add(myControl);
                myControl.Dock = DockStyle.Fill;
            }

            if (e.KeyCode == Keys.F5)
            {

                var myControl = new UcConvenio(idMax, usuarioID, lblSubTotalVal.Text);
                panel11.Controls.Add(myControl);
                myControl.Dock = DockStyle.Fill;
            }
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            if (e.KeyCode == Keys.F6)
            {
                // Adiciona a coluna de botão ao DataGridView
                
                buttonColumn.HeaderText = "Deletar";
                buttonColumn.Name = "Ação";  // Certifique-se de definir o nome da coluna
                buttonColumn.Text = "Deletar";
                buttonColumn.UseColumnTextForButtonValue = true;
                dgvListaProdutos.Columns.Add(buttonColumn);

                teste = true;

                
            }
            if (e.KeyCode == Keys.Escape)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    // Define a visibilidade da coluna de botão para false
                    if (dgvListaProdutos.Columns["Ação"] != null)
                    {
                        dgvListaProdutos.Columns["Ação"].Visible = false;
                    }
                }
            }
        }




        public void LoadList(int id)
        {
            string sql = $"SELECT * FROM VENDAS WHERE CODIGO = {id}";
            DataTable dt = new DataTable();
            dt = BD.Consulta(sql);
            dgvListaProdutos.DataSource = dt;
            dgvListaProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FoVendas2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                FoPagamento foPagamento = new FoPagamento();
                foPagamento.Show();
            }
        }

        private void dgvListaProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (teste)
            {
                // Verifique se a coluna "Ação" existe e se o índice da coluna está correto
                if (e.ColumnIndex == dgvListaProdutos.Columns["Ação"].Index && e.RowIndex >= 0)
                {
                    int idProd = Convert.ToInt32(dgvListaProdutos.Rows[e.RowIndex].Cells["CODIGO_PRODUTO"].Value);
                    ValidaExclusãoProd(idProd);
                    Initialize();
                }
            }
            
        }

        private void ValidaExclusãoProd(int idProd)
        {
            MdProdutos mdProdutos = new MdProdutos();
            if (mdProdutos.ExcluiProdutos(idMax, idProd))
            {
                MessageBox.Show("Produto excluido!");
            }

            else
            {
                MessageBox.Show("Falha ao excluir produtos, favor procure o administrador do sistema");
            }

        }

        

    }
}
