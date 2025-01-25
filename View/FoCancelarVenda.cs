using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmporioRoyal.Model;

namespace EmporioRoyal.View
{
    public partial class FoCancelarVenda : Form
    {
        MdProdutos mdProdutos = new MdProdutos();
        int idVenda;
        int userId;
        public FoCancelarVenda(int idMax, int usuarioID)
        {
            InitializeComponent();
            idVenda = idMax;
            Initialize();
            userId = usuarioID;

        }

        public void Initialize()
        {
            dgvCancelar.DataSource = mdProdutos.CarregaListaVendas(idVenda); ;
            dgvCancelar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Adiciona a coluna de botão ao DataGridView
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Deletar";
            buttonColumn.Name = "Ação";  // Certifique-se de definir o nome da coluna
            buttonColumn.Text = "Clique aqui";
            buttonColumn.UseColumnTextForButtonValue = true;
            dgvCancelar.Columns.Add(buttonColumn);
        }

        private void dgvCancelar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifique se a coluna "Ação" existe e se o índice da coluna está correto
            if (e.ColumnIndex == dgvCancelar.Columns["Ação"].Index && e.RowIndex >= 0)
            {
                int idProd = Convert.ToInt32(dgvCancelar.Rows[e.RowIndex].Cells["CODIGO_PRODUTO"].Value);
                ValidaExclusãoProd(idProd);
            }
        }

        private void ValidaExclusãoProd(int idProd)
        {
            if (mdProdutos.ExcluiProdutos(idVenda, idProd))
            {
                MessageBox.Show("Produto excluido!");
                FoCancelarVenda t = new FoCancelarVenda(idVenda, userId);
                Hide();
                t.ShowDialog();
            }

            else
            {
                MessageBox.Show("Falha ao excluir produtos, favor procure o administrador do sistema");
            }

        }

        private void dgvCancelar_KeyDown_1(object sender, KeyEventArgs e)
        {
            Hide();
            if (this.Owner != null && this.Owner is FoVendas2)
            {
                ((FoVendas2)this.Owner).Initialize();
            }
            else
            {
                MessageBox.Show("Owner não está definido ou não é do tipo FoVendas2.");
            }
        }
    }
}
