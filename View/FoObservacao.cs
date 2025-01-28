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
    public partial class FoObservacao : Form
    {
        int idCliente;
        public FoObservacao(int clientId)
        {
            InitializeComponent();
            idCliente = clientId;
        }

        private void txbObs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                string observacao = string.IsNullOrEmpty(txbObs.Text) ? "-" : txbObs.Text;
                
                DateTime data = DateTime.Today;
                string sql = $"UPDATE DEBITO_CLIENTE SET OBSERVACAO = '{observacao}' WHERE ID_CLIENTE = {idCliente} AND DATA_PAGAMENTO = '{data.ToString("yyyy-MM-dd")}'";


                if (BD.Update(sql))
                {
                    MessageBox.Show("Conta Acertada com Sucesso!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Falha ao atualizar a conta do cliente, favor procurar o administrador do sistema!");
                }
            }
        }
    }
}
