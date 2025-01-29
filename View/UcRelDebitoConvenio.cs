using EmporioRoyal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmporioRoyal.View
{
    public partial class UcRelDebitoConvenio : UserControl
    {
        MdNovoClient novoClient = new MdNovoClient();
        int status = 3;
        public UcRelDebitoConvenio()
        {
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            dgvLista.DataSource = novoClient.ConsultaRelatorioDebitoCompleto(status);
            dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            lblContasAbertas.Text = "Contas Aberta : R$ " + novoClient.ConsultaRelatorioDebitoValores().Rows[0]["ABERTOS"].ToString();
            lblContasFechadas.Text = "Contas Fechada : R$ " + novoClient.ConsultaRelatorioDebitoValores().Rows[0]["FECHADO"].ToString();
            lblTotal.Text = "Total : R$ " + novoClient.ConsultaRelatorioDebitoValores().Rows[0]["TOTAL"].ToString();

            cmbStatus.Items.Add("");
            cmbStatus.Items.Add("ABERTO");
            cmbStatus.Items.Add("FECHADO");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbStatus.SelectedIndex)
            {
                case 0:
                    status = 3;
                break;

                case 1:
                    status = 0;
                break;

                case 2:
                    status = 1;
                break;
            }

            dgvLista.DataSource = novoClient.ConsultaRelatorioDebitoCompleto(status);
            dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
    }
}
