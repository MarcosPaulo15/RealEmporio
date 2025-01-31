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
    public partial class UcAtualizarEstoque : UserControl
    {
        MdProdutos produto = new MdProdutos();
        public UcAtualizarEstoque()
        {
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            dgvLista.DataSource = produto.ListaProdutosAlterarProd(string.Empty);
            dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Verifique se a coluna já existe
            bool colunaExiste = false;
            foreach (DataGridViewColumn coluna in dgvLista.Columns)
            {
                if (coluna.Name == "Ação")
                {
                    colunaExiste = true;
                    break;
                }
            }

            // Se a coluna não existir, adicione-a
            if (!colunaExiste)
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.HeaderText = "Atualizar";
                buttonColumn.Name = "Ação";  // Certifique-se de definir o nome da coluna
                buttonColumn.Text = "Atualizar";
                buttonColumn.UseColumnTextForButtonValue = true;
                dgvLista.Columns.Add(buttonColumn);
            }

        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvLista.Columns["Ação"].Index && e.RowIndex >= 0)
            {
                long idProd = Convert.ToInt64(dgvLista.Rows[e.RowIndex].Cells["CODIGO"].Value);
                //long codigoProd = long.Parse(idProd.ToString());
                FoAtualizaProd fo = new FoAtualizaProd(idProd.ToString());
                fo.ShowDialog();
                Initialize();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (produto.FiltraProdutoAtualizar(txbProduto.Text).Rows.Count > 0)
            {
                dgvLista.DataSource = produto.FiltraProdutoAtualizar(txbProduto.Text);
                dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Codigo produto inválido!");
            }
        }
    }
}
