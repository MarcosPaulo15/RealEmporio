using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EmporioRoyal.Model
{
    public class MdNovoClient
    {
        DataTable dt; 
        int id;
        string nome;
        string telefone;
        char wpp;
        string endereco;
        string bairro;
        char ativo;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }

        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }

        }

        public char Wpp
        {
            get { return wpp; }
            set { wpp = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public char Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        public bool InsertNewClient()
        {

            string sql = $"INSERT INTO CLIENTES VALUES(NULL, " +
                $"'{Nome}', '{Telefone}', '{Wpp}', '{Endereco}', '{Bairro}', '{Ativo}')";
            bool validaInsert = BD.Insert(sql);
            return validaInsert;
        }

        public DataTable CarregaListaCompletaDebitos()
        {
            string sql = "SELECT  DC.ID_CLIENTE AS ID, " +
                         "CLI.NOME, CLI.TELEFONE, " +
                         "(CASE WHEN CLI.WHATSAPP = 1 THEN 'S' ELSE 'N' END) AS WHATSAPP, " +
                         "ROUND(DC.VALOR_TOTAL, 2) AS VALOR_TOTAL " +
                         "FROM DEBITO_CLIENTE DC " +
                         "INNER JOIN CLIENTES CLI ON CLI.ID = DC.ID_CLIENTE WHERE STATUS = 0";

            dt = BD.Consulta(sql);

            return dt;
        }

       public DataTable FiltraDebitoCliente(string filtro)
       {
            string sql = "SELECT DC.ID, " +
                            "CLI.NOME, " +
                            "CLI.TELEFONE, " +
                            "CLI.WHATSAPP, " +
                            "DC.VALOR_TOTAL FROM DEBITO_CLIENTE DC " +
                            "LEFT JOIN CLIENTES CLI ON (CLI.ID = DC.ID_CLIENTE) " +
                            $"WHERE ID_CLIENTE LIKE ('%{filtro}%') OR CLI.NOME LIKE ('%{filtro}%') OR CLI.TELEFONE  LIKE ('%{filtro}%') AND DC.STATUS = '0'";
            dt = BD.Consulta(sql);

            return dt; 
       }

        public DataTable ConsultaRelatorioDebitoCompleto(int status)
        {
            string where = status == 3 ? "" : $"WHERE STATUS = {status}";
            string sql = "SELECT DC.ID, " +
                         "CLI.NOME, " +
                         "DC.VALOR_TOTAL, " +
                         "(CASE WHEN DC.STATUS = 0 THEN 'ABERTO' ELSE 'FECHADA' END) AS STATUS, " +
                         "CLI.TELEFONE, (CASE WHEN WHATSAPP = 1 THEN 'S' ELSE 'N' END) AS WHATSAPP " +
                         $"FROM DEBITO_CLIENTE DC LEFT JOIN CLIENTES CLI ON (DC.ID_CLIENTE = CLI.ID) " + where;


            dt = BD.Consulta(sql);
            return dt;
        }

        public DataTable ConsultaRelatorioDebitoValores()
        {
            string sql = "SELECT (SELECT ROUND(SUM(VALOR_TOTAL), 2) FROM DEBITO_CLIENTE WHERE STATUS = 0)AS ABERTOS, " +
                "(SELECT ROUND(SUM(VALOR_TOTAL), 2) FROM DEBITO_CLIENTE WHERE STATUS = 1) AS FECHADO, " +
                "ROUND(SUM(VALOR_TOTAL), 2) AS TOTAL FROM DEBITO_CLIENTE DC";


            dt = BD.Consulta(sql);
            return dt;
        }
    }
}
