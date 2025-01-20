using EmporioRoyal.View;
using System.Data;
using System.Data.Entity.Core.Common.EntitySql;

namespace EmporioRoyal
{
    public partial class FoLogin : Form
    {
        DataTable dt = new DataTable();
        public FoLogin()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string usuario = txbUser.Text;
            string senha = txbPassword.Text;

            if(usuario == "" || usuario == "")
            {

                MessageBox.Show("Favor preencher os campos de usuário e senha!");
            }
            else
            {
                string sql = $"SELECT * FROM USUARIOS WHERE USUARIO = '{usuario}' AND SENHA = '{senha}'";
                dt = BD.Consulta(sql);

                if (dt.Rows.Count == 1)
                {
                    FoPrincipal principal = new FoPrincipal();

                    principal.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Usuario ou senha incorreto, favor digite novamente!");
                }
            }
        }
    }
}
