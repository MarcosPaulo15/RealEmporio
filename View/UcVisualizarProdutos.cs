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
    public partial class UcVisualizarProdutos : UserControl
    {
        public UcVisualizarProdutos()
        {
            InitializeComponent();
            CarregaLista();
        }

        public void CarregaLista()
        {
            string sql = "SELECT * FROM PRODUTOS";
            DataTable dt = new DataTable();
            dt = BD.Consulta(sql);
            dgvLista.DataSource = dt;
            dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void dgvLista_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        // Método para redefinir o estilo da linha para o padrão
        private void ResetRowStyle(int rowIndex)
        {
            dgvLista.Rows[rowIndex].DefaultCellStyle.BackColor = dgvLista.DefaultCellStyle.BackColor;
            dgvLista.Rows[rowIndex].DefaultCellStyle.ForeColor = dgvLista.DefaultCellStyle.ForeColor;
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
    }
}
