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
        public FoPrincipal()
        {
            InitializeComponent();
            pcLogo.Visible = true;
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
    }
}
