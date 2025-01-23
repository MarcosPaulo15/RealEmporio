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
    public partial class UcRelVendas : UserControl
    {
        MdProdutos mdProdutos = new MdProdutos();
        DataTable dt = new DataTable();
        public UcRelVendas()
        {
            InitializeComponent();
            Initialize();
            dtpData.Format = DateTimePickerFormat.Custom;
            dtpData.CustomFormat = "dd-MM-yyyy";
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            
            /*dt = BD.Consulta(sql);
            dgvLista.DataSource = dt;
            dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;*/
        }

        private void Initialize()
        {
            dgvRelatorio.DataSource = mdProdutos.ListaCompletaVendas();
            dgvRelatorio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            string tipo = mdProdutos.ListaCompletaTipoVenda().Rows[0]["TIPO"].ToString();
            lblTotalCard.Text = "TOTAL CARTÃO = " + tipo;
        }
    }
}
