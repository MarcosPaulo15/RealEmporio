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
        int idMax;
        public FoVendas2()
        {
            InitializeComponent();
            //Initialize();
        }

        public FoVendas2(int id)
        {
            InitializeComponent();
            //Initialize(id);
            idMax = id;
        }

        public FoVendas2(bool fecha)
        {
            if (fecha)
                Close();
        }
        public void Initialize(int id)
        {
            MessageBox.Show(id.ToString());

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

                        if (produto.InserirProdutosVendas(idMax, codigo))
                        {
                            if (produto.CarregaListaVendas(idMax).Rows.Count > 0)
                            {

                                dgvListaProdutos.DataSource = produto.CarregaListaVendas(idMax);
                                dgvListaProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                                if (produto.SomaTodosValores(idMax).Rows.Count > 0)
                                {
                                    // string valorTotal = produto.SomaTodosValores(idMax).Rows[0]["TOTAL"].ToString();
                                    //lblSubTotalVal.Text = "R$" + valorTotal + ",00";
                                    lblSubTotalVal.Text = produto.SomaTodosValores(idMax).Rows[0]["TOTAL"].ToString();
                                    txbCodigoBarras.Clear();
                                }
                            }


                        }
                    }
                }

            }
            if (e.KeyCode == Keys.F1)
            {

                if (mdProdutos.InsereTipoVenda(idMax, '1'))
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

                if (mdProdutos.InsereTipoVenda(idMax, '2'))
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

                if (mdProdutos.InsereTipoVenda(idMax, '3'))
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
                var myControl = new UcTroco(idMax);
                panel11.Controls.Add(myControl);
                myControl.Dock = DockStyle.Fill;
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
    }
}
