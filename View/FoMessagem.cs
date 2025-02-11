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
    public partial class FoMessagem : Form
    {
        public FoMessagem()
        {
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            MdProdutos prod = new MdProdutos();
            dgvQtdMin.DataSource = prod.ExibeMsg();
            dgvQtdMin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
