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
    public partial class FoAprovaFechamento : Form
    {
        MdProdutos mdProdutos = new MdProdutos();
        public FoAprovaFechamento(int userId)
        {
            InitializeComponent();
            this.TopMost = true;
            Initialize(userId);
        }

        public void Initialize(int idUser)
        {
            
            dgvAprova.DataSource = mdProdutos.CarregaListaFechamento(idUser); ;
            dgvAprova.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Adiciona a coluna de botão ao DataGridView
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Ação";
            buttonColumn.Name = "Ação";  // Certifique-se de definir o nome da coluna
            buttonColumn.Text = "Clique aqui";
            buttonColumn.UseColumnTextForButtonValue = true;
            dgvAprova.Columns.Add(buttonColumn);

            // Adicione o evento CellContentClick após configurar as colunas
            dgvAprova.CellContentClick += dgvAprova_CellContentClick;
        }

        private void dgvAprova_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifique se a coluna "Ação" existe e se o índice da coluna está correto
            if (e.ColumnIndex == dgvAprova.Columns["Ação"].Index && e.RowIndex >= 0)
            {
                int idUser = Convert.ToInt32(dgvAprova.Rows[e.RowIndex].Cells["CODIGO_USUARIO"].Value);
                AprovacaoFechamentoCaixa(idUser);
            }
        }


        private void AprovacaoFechamentoCaixa(int idUsu)
        {
            if (mdProdutos.AprovaFechamento(idUsu))
            {
                MessageBox.Show("Fechamento deste usuario realizado! Obrigado!");
                Hide();
            }
            else
            {
                MessageBox.Show("Falha ao realizar o fechamento do usuário, favor procurar administrador dos sistema!");
            }
        }


    }
}
