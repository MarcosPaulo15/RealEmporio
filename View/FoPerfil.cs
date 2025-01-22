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
        public FoPerfil()
        {
            InitializeComponent();
        }

        private void FoPerfil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                MdProdutos mdProdutos = new MdProdutos();
                string maximo = mdProdutos.IdMax().Rows[0]["CODIGO"].ToString();
                int idMax = int.Parse(maximo) + 1;
                FoVendas2 foVendas = new FoVendas2(idMax);
                foVendas.ShowDialog();
            }
        }
    }
}
