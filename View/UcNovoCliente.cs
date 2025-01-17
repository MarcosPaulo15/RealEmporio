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
    public partial class UcNovoCliente : UserControl
    {
        public UcNovoCliente()
        {
            InitializeComponent();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            InsertClient();
        }

        public void InsertClient()
        {
            if (string.IsNullOrEmpty(txbNome.Text))
            {
                MessageBox.Show("Campo nome está vazio favor preencher");
            }
            else if (string.IsNullOrEmpty(txbEnd.Text) || string.IsNullOrEmpty(txbBairro.Text))
            {

                MessageBox.Show("Campos Endereço ou bairro vazio, favor preencher corretamente!");
            }
            else
            {
                MdNovoClient mdCliente = new MdNovoClient();
                mdCliente.Nome = txbNome.Text;
                mdCliente.Telefone = string.IsNullOrEmpty(txbTelefone.Text) ? "NULL" : txbTelefone.Text;
                mdCliente.Wpp = ckbWhats.Checked ? '1' : '0';
                mdCliente.Endereco = string.IsNullOrEmpty(txbEnd.Text) ? "NULL" : txbEnd.Text;
                mdCliente.Bairro = string.IsNullOrEmpty(txbBairro.Text) ? "NULL" : txbBairro.Text;
                mdCliente.Ativo = ckbAtivo.Checked ? '1' : '0';

                if (mdCliente.InsertNewClient())
                {
                    MessageBox.Show("Cliente inserido com sucesso!");
                    txbNome.Clear();
                    txbTelefone.Clear();
                    ckbWhats.Checked = false;
                    ckbAtivo.Checked = false;
                    txbEnd.Clear();
                    txbBairro.Clear();
                }
                else
                {
                    MessageBox.Show("Falha ao inserir cliente, favor entre em contato com o administrador do sistema!");
                }
            }

        }
    }
}
