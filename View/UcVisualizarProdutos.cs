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
    }
}
