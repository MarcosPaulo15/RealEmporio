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
    public partial class FoPerfil : Form
    {
        string nome = string.Empty;
        int idUser;
        public FoPerfil()
        {
            InitializeComponent();
        }

        public FoPerfil(string usuario, int id)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuário: " + usuario;
            nome = usuario;
            idUser = id;
        }

        private void FoPerfil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                MdProdutos mdProdutos = new MdProdutos();
                string maximo = mdProdutos.IdMax().Rows[0]["CODIGO"].ToString();
                int idMax = int.Parse(maximo) + 1;
                FoVendas2 foVendas = new FoVendas2(idMax, idUser);
                foVendas.ShowDialog();
            }
            if (e.KeyCode == Keys.F12)
            {
                MdProdutos mdProdutos = new MdProdutos();
                string message = mdProdutos.SolicitaFechamentoCaixa(idUser) ? "CAIXA FECHADO COM SUCESSO!" : "FALHA AO FECHAR O CAIXA, FAVOR CONTATE ADMINISTRADOR DO SISTEMA";
                MessageBox.Show(message);
            }
        }
    }
}
