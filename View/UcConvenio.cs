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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmporioRoyal.View
{
    public partial class UcConvenio : UserControl
    {
        int codigoCompra;
        int userId;
        string total; 
        public UcConvenio(int idCompra, int idUser, string ValorRecebido)
        {
            InitializeComponent();
            Initialize();
            codigoCompra = idCompra;
            userId = idUser;
            total = ValorRecebido;
        }

        public void Initialize()
        {
            string query = "SELECT ID, NOME FROM CLIENTES";
            DataTable dt = BD.Consulta(query);
            
            /*foreach (DataRow row in dt.Rows)
            {
                cmbCliente.Items.Add(row["NOME"].ToString());
                
            }*/

            cmbCliente.DisplayMember = "NOME";
            cmbCliente.ValueMember = "ID";
            cmbCliente.DataSource = dt;

        }

        private void cmbCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                MdProdutos mdProdutos = new MdProdutos();
                    if (cmbCliente.SelectedValue != null)
                    {
                        string codigoId = cmbCliente.SelectedValue.ToString();

                        if (mdProdutos.InsereTipoVenda(codigoCompra, '5', userId, '0', '0', codigoId))
                        {
                            if (mdProdutos.InserirDebitoCliente(codigoId, total))
                            {
                                MessageBox.Show("Compra tipo convenio Concluida com sucesso!");
                                Form parentForm = this.FindForm();
                                if (parentForm != null)
                                {
                                    parentForm.Close();
                                }
                                e.Handled = true;
                            }
                            else 
                            {
                            MessageBox.Show("Erro ao inserir a compra ao cliente, favor procure o administrador do sistema!");
                            }

                    }
                        else
                        {
                            MessageBox.Show("Erro ao inserir a compra, favor procure o administrador do sistema!");
                        }
                }
                    else
                    {

                    }
                
                
                        
                //MessageBox.Show(codigoCliente.ToString());
                //mdProdutos.RecuperaIdCmb(cmbCliente.Text);
                
            }
        }
    }
}
