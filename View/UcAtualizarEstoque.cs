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

        private void dgvLista_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dgvLista.Rows[e.RowIndex].Cells["QUANTIDADE_MINIMA"].Value != DBNull.Value &&
                dgvLista.Rows[e.RowIndex].Cells["QUANTIDADE_ATUAL"].Value != DBNull.Value)
            {
                double qtdmin = Convert.ToDouble(dgvLista.Rows[e.RowIndex].Cells["QUANTIDADE_MINIMA"].Value);
                double qtdmax = Convert.ToDouble(dgvLista.Rows[e.RowIndex].Cells["QUANTIDADE_ATUAL"].Value);

                if (qtdmax <= qtdmin)
                {
                    foreach (DataGridViewCell cell in dgvLista.Rows[e.RowIndex].Cells)
                    {
                        e.CellStyle.BackColor = Color.Pink;
                    }
                }
                else
                {
                    foreach (DataGridViewCell cell in dgvLista.Rows[e.RowIndex].Cells)
                    {
                        e.CellStyle.BackColor = Color.LightGreen;
                    }
                }
            }

            
        }

        // Variável para armazenar a linha anterior
        private int previousRowIndex = -1;

        private void dgvLista_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex != previousRowIndex)
            {
                // Remove o sombreamento da linha anterior, se houver
                if (previousRowIndex >= 0)
                {
                    ResetRowStyle(previousRowIndex);
                }

                // Sombreia a linha atual
                dgvLista.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
                previousRowIndex = e.RowIndex;
            }
        }

        private void dgvLista_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex == previousRowIndex)
            {
                // Remove o sombreamento da linha atual
                ResetRowStyle(e.RowIndex);
                previousRowIndex = -1;

            }
        }

        // Método para redefinir o estilo da linha para o padrão
        private void ResetRowStyle(int rowIndex)
        {
            dgvLista.Rows[rowIndex].DefaultCellStyle.BackColor = dgvLista.DefaultCellStyle.BackColor;
            dgvLista.Rows[rowIndex].DefaultCellStyle.ForeColor = dgvLista.DefaultCellStyle.ForeColor;
        }
    }
}
