using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.EntitySql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

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
        double precoCusto;
        string porcentagem;
        string quantidadeAtual;
        string tipoMedida;

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

        public double PrecoCusto
        {
            get { return precoCusto; }
            set { precoCusto = value; }
        }

        public string Porcentagem
        {
            get { return porcentagem; }
            set { porcentagem = value; }
        }

        public string QuantidadeAtual
        {
            get { return quantidadeAtual; }
            set { quantidadeAtual = value; }
        }

        public string TipoMedida
        {
            get { return tipoMedida; }
            set { tipoMedida = value; }
        }

        public bool insert()
        {
            DateTime data = DateTime.Today;
            
            string query = $"INSERT INTO PRODUTOS VALUES({Codigo}, '{Nome}', '{Descricao}', {Quantidade}, '{Valor}', '{data.ToString("yyyy-MM-dd")}', '{PrecoCusto}', {Porcentagem}, '{QuantidadeAtual}', '{tipoMedida}' )";
            bool validaInsertProdutos = BD.Insert(query);
            return validaInsertProdutos;
        }

        public DataTable ProcurarProduto(long id)
        {

            string sql = $"SELECT * FROM PRODUTOS WHERE CODIGO = {id}";
            DataTable dt = BD.Consulta(sql);

            return dt;
        }

        public DataTable ListaProdutosAlterarProd(string id)
        {
            string where = id != "" ? $"WHERE CODIGO = {id}" : "";
            string sql = "SELECT CODIGO, NOME, QUANTIDADE_MINIMA, VALOR, PRECO_CUSTO, PORCENTAGEM, QUANTIDADE_ATUAL, DESCRICAO FROM PRODUTOS " + where;

            dt = BD.Consulta(sql);
            return dt;
        }

        public bool AtualizarProdutos(string codigo, string nome,string descricao, int quantidadeMin, string valorCusto, string precoVenda, string porcentagem, int quantidadeAtual, string id)
        {
            string sql = $"UPDATE PRODUTOS SET CODIGO = '{codigo}', NOME = '{nome}',  DESCRICAO = '{descricao}', QUANTIDADE_MINIMA = {quantidadeMin}, PRECO_CUSTO = {valorCusto}, VALOR = {precoVenda}, PORCENTAGEM = {porcentagem}, QUANTIDADE_ATUAL = {quantidadeAtual} WHERE CODIGO = {id}";

            return BD.Update(sql);
        }

        public DataTable FiltraProdutoAtualizar(string produto)
        {
            string where = produto == "" ? "" : $"WHERE CODIGO LIKE '%{produto}%' OR NOME LIKE ('%{produto}%')";
            string sql = $"SELECT CODIGO, NOME, QUANTIDADE_MINIMA, VALOR, PRECO_CUSTO, PORCENTAGEM, QUANTIDADE_ATUAL, DESCRICAO FROM PRODUTOS " + where;
            dt = BD.Consulta(sql);

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
            string sql = $"SELECT V.ID_PRODUTO AS CODIGO_PRODUTO, P.NOME, V.VALOR FROM VENDAS V LEFT JOIN PRODUTOS P ON P.CODIGO = V.ID_PRODUTO WHERE V.CODIGO = {id}";
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

        public bool InserirDebitoCliente(string codigoCliente, string valorRecebido)
        {
            //string validaCliente = $"SELECT ROUND(SUM(VALOR_TOTAL), 2) AS TOTAL FROM DEBITO_CLIENTE WHERE ID_CLIENTE = {codigoCliente}";
            string validaCliente = $"SELECT * FROM DEBITO_CLIENTE WHERE ID_CLIENTE = {codigoCliente} AND STATUS = '0'";
            string g;
            dt = BD.Consulta(validaCliente);

            //Validação para verificar se existe mais de um registro, se sim ele soma os valore, se não so pega o valor que está la.
            if (dt.Rows.Count > 0) {
                string somaValores = $"SELECT ROUND(SUM(VALOR_TOTAL), 2) AS TOTAL FROM DEBITO_CLIENTE WHERE ID_CLIENTE = {codigoCliente} AND STATUS = 0 ";
                dt = BD.Consulta(somaValores);
                g = dt.Rows[0]["TOTAL"].ToString();
            }
            else
            {
                g = "";
                DataTable k = new DataTable();
                validaCliente = $"SELECT ID, ROUND(VALOR_TOTAL, 2) AS VALOR_TOTAL FROM DEBITO_CLIENTE WHERE ID_CLIENTE = {codigoCliente} AND STATUS = 0";
                k = BD.Consulta(validaCliente) ;
                /*if (k.Columns.Contains("VALOR_TOTAL"))
                {
                    g = k.Rows[0]["VALOR_TOTAL"].ToString();
                }*/

            }
            
            if (!string.IsNullOrEmpty(g) || g != "")
            {                
                double valorInserido = double.Parse(g);
                valorRecebido = valorRecebido.Replace("R$", "").Trim();
                double recebido = Convert.ToDouble(valorRecebido);
                recebido = Math.Round(recebido, 2);
                double total = valorInserido + recebido;
                string sql = $"UPDATE DEBITO_CLIENTE SET VALOR_TOTAL = {total} WHERE ID_CLIENTE = {codigoCliente} AND STATUS = '0'";
                string query = sql.Replace(",", ".");
                return BD.Update(query);
            }
            else
            {
                int idCliente = int.Parse(codigoCliente);
                valorRecebido = valorRecebido.Replace(',', '.');
                valorRecebido = valorRecebido.Replace("R$", "").Trim();
                string sql = $"INSERT INTO DEBITO_CLIENTE VALUES(NULL, {idCliente}, '{valorRecebido}', '0', NULL, NULL)";
                return BD.Insert(sql);
            }
        }
        
        public bool AtualizaSituacaoCli(int codigoCliente)
        {
            DateTime data = DateTime.Today;
            string sql = $" UPDATE DEBITO_CLIENTE SET STATUS = '1', DATA_PAGAMENTO = '{data.ToString("yyyy-MM-dd")}'  WHERE ID_CLIENTE = {codigoCliente} AND STATUS = '0'";
            return BD.Update(sql);
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

        public bool AprovaFechamento(int idUsu, string data)
        {
            string query = $"UPDATE REL_TIPO_ENTRADA_CAIXA SET APROVA_FECHAMENTO = '1' WHERE ID_USER = {idUsu} AND DATA = '{data}'";
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
                "WHERE DATA BETWEEN date('now', '-30 days') AND date('now') AND RTE.TIPO_ENTRADA <> '5'; ";

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
            string sql = "select ROUND(SUM(VALOR_TOTAL), 2) AS total from REL_TIPO_ENTRADA_CAIXA WHERE TIPO_ENTRADA = 3 " + validaWhere;

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
            validaWhere = string.IsNullOrEmpty(validaWhere) ? "WHERE RTE.TIPO_ENTRADA <> 5 " : validaWhere + "AND RTE.TIPO_ENTRADA <> 5 ";
            string sql = "SELECT RTE.DATA, " +
                "TE.NOME AS TIPO_PAGAMENTO, " +
                "ROUND(SUM(RTE.VALOR_TOTAL), 2) AS TOTAL " +
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
                $"WHERE DATA BETWEEN '{dataInicio}' AND '{dataFim}' AND RTE.TIPO_ENTRADA <> 5";

            dt = BD.Consulta(sql);
            return dt;
        }


        public bool InsereClienteCompra(string codigoCliente, int codigoCompra)
        {

            string sql = $"UPDATE REL_TIPO_ENTRADA_CAIXA SET CODIGO_CLIENTE = '{codigoCliente}' WHERE ID_VENDA = {codigoCompra}";

            return BD.Update(sql);
        }

        public bool ExcluiProdutos(int idVenda, int idProd)
        {
            string sql = $"DELETE FROM VENDAS WHERE CODIGO = {idVenda} AND ID_PRODUTO = {idProd}";

            return BD.Delete(sql);
        }

        public bool ReduzValorTotal(double valorReduzido, int idCliente)
        {
            valorReduzido = Math.Round(valorReduzido, 2);
            string sql = $"UPDATE DEBITO_CLIENTE SET VALOR_TOTAL = {valorReduzido.ToString().Replace(",", ".")} WHERE ID_CLIENTE = {idCliente} AND STATUS = 0";

            return BD.Update(sql);
        }

        public bool AtualizaEstoque(long codigo)
        {
            string query = $"SELECT QUANTIDADE_ATUAL FROM PRODUTOS WHERE CODIGO = {codigo}";
            dt = BD.Consulta(query);

            int quantidadeAtual = int.Parse(dt.Rows[0]["QUANTIDADE_ATUAL"].ToString());
            int quantidadeAlterada = quantidadeAtual - 1;

            string sql = $"UPDATE PRODUTOS SET QUANTIDADE_ATUAL = {quantidadeAlterada}  WHERE CODIGO = {codigo}";

            return BD.Update(sql);
        }
    }
}
