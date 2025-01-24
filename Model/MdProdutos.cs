using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.EntitySql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmporioRoyal.Model
{
    internal class MdProdutos
    {
        DataTable dt;
        long codigo;
        string nome;
        string valor;
        int quantidade;
        string descricao;
        DateTime vencimento;

        public long Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public DateTime Vencimento
        {
            get { return vencimento; }
            set { vencimento = value; }
        }


        public bool insert()
        {
            string query = $"INSERT INTO PRODUTOS VALUES({Codigo}, '{Nome}', '{Descricao}', {Quantidade}, '{Valor}', NULL )";
            bool validaInsertProdutos = BD.Insert(query);
            return validaInsertProdutos;
        }

        public DataTable ProcurarProduto(long id)
        {

            string sql = $"SELECT * FROM PRODUTOS WHERE CODIGO = {id}";
            DataTable dt = BD.Consulta(sql);

            return dt;
        }

        public DataTable IdMax()
        {
            string sql = "SELECT MAX(CODIGO) AS CODIGO FROM VENDAS ";
            DataTable dt = new DataTable();
            dt = BD.Consulta(sql);

            return dt;
        }

        public bool InserirProdutosVendas(int idMax, long idProd, int idUsuario)
        {
            DateTime dataAtual = DateTime.Today;
            string sql = $"INSERT INTO VENDAS SELECT {idMax} AS CODIGO," +
                $"CODIGO AS ID_PRODUTO, VALOR AS VALOR, " +
                $"'{dataAtual}' AS DATA, {idUsuario} AS ID_USER FROM PRODUTOS WHERE ID_PRODUTO = {idProd} ";

            bool insert = BD.Insert(sql);

            return insert;

        }

        public DataTable CarregaListaVendas(int id)
        {
            string sql = $"SELECT P.NOME, V.VALOR FROM VENDAS V LEFT JOIN PRODUTOS P ON P.CODIGO = V.ID_PRODUTO WHERE V.CODIGO = {id}";
            DataTable dt = new DataTable();
            dt = BD.Consulta(sql);

            return dt;
        }

        public DataTable SomaTodosValores(int id)
        {
            DataTable dataTable = new DataTable();
            string sql = $"SELECT ROUND(SUM(VALOR), 2) AS TOTAL FROM VENDAS WHERE CODIGO = {id}";
            dt = BD.Consulta(sql);
            return dt;
        }

        public bool InsereTipoVenda(int id, char tipo_entrada, int id_user, char fechamentoCaixa, char aprovaFechamento, string codigoCliente)
        {
            DateTime dataAtual = DateTime.Today;
            string data = dataAtual.ToString("yyyy-MM-dd");
            string sql = $"INSERT INTO REL_TIPO_ENTRADA_CAIXA " +
                $"SELECT NULL AS CODIGO, " +
                $"'{data}' AS DATA, " +
                $"'{tipo_entrada}' AS TIPO_ENTRADA, " +
                $"SUM(VALOR) AS VALOR_TOTAL, " +
                $"CODIGO AS ID_VENDA," +
                $"{id_user} AS ID_USER, " +
                $"'{fechamentoCaixa}' AS FECHAMENTO_CAIXA, " +
                $"'{aprovaFechamento}' AS APROVA_FECHAMENTO," +
                $" '{codigoCliente}' AS CODIGO_CLIENTE FROM VENDAS WHERE CODIGO = {id} ";

            return BD.Insert(sql); 
        }

        public bool SolicitaFechamentoCaixa(int idUsuario)
        {
            DateTime dateTime = DateTime.Today;
            string data = dateTime.ToString("yyyy-MM-dd");
            string sql = $"UPDATE REL_TIPO_ENTRADA_CAIXA SET FECHAMENTO_CAIXA = '1' WHERE ID_USER = {idUsuario} AND DATA = '{data}'";
            return BD.Update(sql);
        }

        public DataTable CarregaListaFechamento(int codigoUsu)
        {
            string query = "SELECT RTE.ID_USER AS CODIGO_USUARIO, USU.NOME, " +
                "DATE(RTE.DATA) AS DATA, " +
                "SUM(RTE.VALOR_TOTAL) AS TOTAL " +
                "FROM REL_TIPO_ENTRADA_CAIXA RTE " +
                "LEFT JOIN USUARIOS USU ON RTE.ID_USER = USU.ID " +
                "WHERE FECHAMENTO_CAIXA = '1'" +
                "  AND APROVA_FECHAMENTO = '0'" +
                "GROUP BY USU.NOME, DATE(RTE.DATA)";
            
            dt = BD.Consulta(query);
            return dt;
        }

        public bool AprovaFechamento(int idUsu)
        {
            string query = $"UPDATE REL_TIPO_ENTRADA_CAIXA SET APROVA_FECHAMENTO = '1' WHERE ID_USER = {idUsu}";
            return BD.Update(query);
        }

        /*public DataTable CarregaListaRelatorioVenda(string data)
        {
            string sql = "SELECT * FROM ";
            DataTable dt = new DataTable();
        }*/


        public DataTable ListaCompletaVendas()
        {
            string sql = "SELECT RTE.DATA, " +
                "TE.NOME AS TIPO_PAGAMENTO, " +
                "RTE.VALOR_TOTAL AS TOTAL  " +
                "FROM REL_TIPO_ENTRADA_CAIXA  RTE " +
                "LEFT JOIN TIPO_ENTRADA TE ON TE.CODIGO = RTE.TIPO_ENTRADA  " +
                "WHERE DATA BETWEEN date('now', '-30 days') AND date('now'); ";

            dt = BD.Consulta(sql);
            return dt;
        }

        public DataTable ListaCompletaTipoVenda(string dataInicio, string dataFim)
        {
            string validaWhere = "";
            if (!string.IsNullOrEmpty(dataInicio) && !string.IsNullOrEmpty(dataFim))
            {
                validaWhere = $"AND DATA BETWEEN '{dataInicio}' AND '{dataFim}'";
            }

            string sql = "select CAST(SUM(VALOR_TOTAL) AS DECIMAL) AS total from REL_TIPO_ENTRADA_CAIXA WHERE TIPO_ENTRADA in (1,2) " + validaWhere;

            dt = BD.Consulta(sql);
            return dt;
        }

        public DataTable ListaCompletaTipoDinheiro(string dataInicio , string dataFim)
        {
            string validaWhere = "";
            if (!string.IsNullOrEmpty(dataInicio) && !string.IsNullOrEmpty(dataFim)) 
            {
                validaWhere = $"AND DATA BETWEEN '{dataInicio}' AND '{dataFim}'";
            }
            
            string sql = "select SUM(VALOR_TOTAL) AS total from REL_TIPO_ENTRADA_CAIXA WHERE TIPO_ENTRADA = 4 " + validaWhere;

            dt = BD.Consulta(sql);
            return dt;
        }

        public DataTable ListaCompletaTipoPix(string dataInicio, string dataFim)
        {
            string validaWhere = "";
            if (!string.IsNullOrEmpty(dataInicio) && !string.IsNullOrEmpty(dataFim))
            {
                validaWhere = $"AND DATA BETWEEN '{dataInicio}' AND '{dataFim}'";
            }
            string sql = "select CAST(SUM(VALOR_TOTAL) AS DECIMAL) AS total from REL_TIPO_ENTRADA_CAIXA WHERE TIPO_ENTRADA = 3 " + validaWhere;

            dt = BD.Consulta(sql);
            return dt;
        }

        public DataTable ListaCompletaTipoTotal(string dataInicio, string dataFim)
        {
            string validaWhere = "";
            if (!string.IsNullOrEmpty(dataInicio) && !string.IsNullOrEmpty(dataFim))
            {
                validaWhere = $"WHERE DATA BETWEEN '{dataInicio}' AND '{dataFim}'";
            }

            string sql = "SELECT RTE.DATA, " +
                "TE.NOME AS TIPO_PAGAMENTO, " +
                "SUM(RTE.VALOR_TOTAL) AS TOTAL  " +
                "FROM REL_TIPO_ENTRADA_CAIXA  RTE " +
                "LEFT JOIN TIPO_ENTRADA TE ON TE.CODIGO = RTE.TIPO_ENTRADA " + validaWhere;

            dt = BD.Consulta(sql);
            return dt;
        }

        public DataTable RelatorioData(string dataInicio, string dataFim)
        {
            string sql = "SELECT RTE.DATA, " +
                "TE.NOME AS TIPO_PAGAMENTO, " +
                "RTE.VALOR_TOTAL AS TOTAL  " +
                "FROM REL_TIPO_ENTRADA_CAIXA  RTE " +
                "LEFT JOIN TIPO_ENTRADA TE ON TE.CODIGO = RTE.TIPO_ENTRADA " +
                $"WHERE DATA BETWEEN '{dataInicio}' AND '{dataFim}'";

            dt = BD.Consulta(sql);
            return dt;
        }


        public bool InsereClienteCompra(string codigoCliente, int codigoCompra)
        {

            string sql = $"UPDATE REL_TIPO_ENTRADA_CAIXA SET CODIGO_CLIENTE = '{codigoCliente}' WHERE ID_VENDA = {codigoCompra}";

            return BD.Update(sql);
        }
    }
}
