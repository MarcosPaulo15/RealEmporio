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
            dtpDataFim.Format = DateTimePickerFormat.Custom;
            dtpDataFim.CustomFormat = "dd-MM-yyyy";
        }

        private void Initialize()
        {
            dgvRelatorio.DataSource = mdProdutos.ListaCompletaVendas();
            dgvRelatorio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            string tipo = mdProdutos.ListaCompletaTipoVenda(string.Empty, string.Empty).Rows[0]["TOTAL"].ToString();
            lblTotalCard.Text = "TOTAL CARTÃO: R$" + tipo;
            string dinheiro = mdProdutos.ListaCompletaTipoDinheiro(string.Empty, string.Empty).Rows[0]["TOTAL"].ToString();
            double valor = Convert.ToDouble(dinheiro);
            lblDinheiro.Text = "TOTAL DINHEIRO: R$" + valor.ToString("F2");
            string pix = mdProdutos.ListaCompletaTipoPix(string.Empty, string.Empty).Rows[0]["TOTAL"].ToString();
            lblPix.Text = "TOTAL PIX: R$ " + pix;            
            string total = mdProdutos.ListaCompletaTipoTotal(string.Empty, string.Empty).Rows[0]["TOTAL"].ToString();
            lblTotal.Text = "TOTAL : R$ " + total;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime dataInic = dtpData.Value;
            DateTime dataFim = dtpDataFim.Value;

            dgvRelatorio.DataSource = mdProdutos.RelatorioData(dataInic.ToString("yyyy-MM-dd"), dataFim.ToString("yyyy-MM-dd"));
            dgvRelatorio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            string tipo = mdProdutos.ListaCompletaTipoVenda(dataInic.ToString("yyyy-MM-dd"), dataFim.ToString("yyyy-MM-dd")).Rows[0]["TOTAL"].ToString();
            tipo = string.IsNullOrEmpty(tipo) ? "0,00" : tipo;
            lblTotalCard.Text = "TOTAL CARTÃO: R$ " + tipo;
            string dinheiro = mdProdutos.ListaCompletaTipoDinheiro(dataInic.ToString("yyyy-MM-dd"), dataFim.ToString("yyyy-MM-dd")).Rows[0]["TOTAL"].ToString();
            double valor = string.IsNullOrEmpty(dinheiro) ? 0.00 : Convert.ToDouble(dinheiro);
            lblDinheiro.Text = "TOTAL DINHEIRO: R$ " + valor.ToString("F2");
            string pix = mdProdutos.ListaCompletaTipoPix(dataInic.ToString("yyyy-MM-dd"), dataFim.ToString("yyyy-MM-dd")).Rows[0]["TOTAL"].ToString();
            pix = string.IsNullOrEmpty(pix) ? "0,00" : pix;
            lblPix.Text = "TOTAL PIX: R$ " + pix;            
            string total = mdProdutos.ListaCompletaTipoTotal(dataInic.ToString("yyyy-MM-dd"), dataFim.ToString("yyyy-MM-dd")).Rows[0]["TOTAL"].ToString();
            lblTotal.Text = "TOTAL : R$ " + total;
        }
    }
}
