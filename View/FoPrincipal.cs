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
    public partial class FoPrincipal : Form
    {
        int usuarioId;
        public FoPrincipal()
        {
            InitializeComponent();
            pcLogo.Visible = true;
        }

        public FoPrincipal(string usuario, int idUser)
        {
            InitializeComponent();
            pcLogo.Visible = true;
            lblUsuario.Text = "Usuário: " + usuario;
            usuarioId = idUser;
        }
        private void adicionarNovoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*UcNovoCliente ucNewClient = new UcNovoCliente();
            panMenu.Controls.Add(ucNewClient);
            ucNewClient.Dock = DockStyle.Fill;*/

            var myControl = new UcNovoCliente();
            pcLogo.Controls.Add(myControl);
            myControl.Dock = DockStyle.Fill;
            //spcLogo.Visible = false;
        }

        private void verClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myControl = new UcVisualiza();
            pcLogo.Controls.Add(myControl);
            myControl.Dock = DockStyle.Fill;
        }

        private void registrarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myControl = new UcRegistrarProduto();
            pcLogo.Controls.Add(myControl);
            myControl.Dock = DockStyle.Fill;
        }

        private void entradaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myControl = new UcVisualizarProdutos();
            pcLogo.Controls.Add(myControl);
            myControl.Dock = DockStyle.Fill;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FecharTodosUserControls()
        {
            // Preserve a lista de controles para evitar modificação enquanto itera
            var userControls = pcLogo.Controls.OfType<UserControl>().ToList();

            // Iterar sobre cada UserControl e removê-los do PictureBox
            foreach (var userControl in userControls)
            {
                pcLogo.Controls.Remove(userControl);
                userControl.Dispose(); // Opcional: liberar recursos
            }
        }


        private void tlsInicio_Click(object sender, EventArgs e)
        {
            FecharTodosUserControls();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MdProdutos mdProdutos = new MdProdutos();
            string maximo = mdProdutos.IdMax().Rows[0]["CODIGO"].ToString();
            int idMax = int.Parse(maximo) + 1;
            FoVendas2 foVendas = new FoVendas2(idMax, usuarioId);
            foVendas.ShowDialog();
        }

        private void tlsAprovaFechamento_Click(object sender, EventArgs e)
        {
            FoAprovaFechamento aprova = new FoAprovaFechamento(usuarioId);
            aprova.TopMost = true;
            aprova.Show();
        }

        private void relatórioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myControl = new UcRelVendas();
            pcLogo.Controls.Add(myControl);
            myControl.Dock = DockStyle.Fill;
        }
    }
}
