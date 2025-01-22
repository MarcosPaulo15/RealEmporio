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
        int codigo;
        string nome;
        string valor;
        int quantidade;
        string descricao;
        DateTime vencimento;

        public int Codigo
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
            string query = $"INSERT INTO PRODUTOS VALUES({Codigo}, '{Nome}', '{Descricao}', {Quantidade}, NULL, '{Valor}')";
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

        public bool InserirProdutosVendas(int idMax, long idProd)
        {
            DateTime dataAtual = DateTime.Today;
            string sql = $"INSERT INTO VENDAS SELECT {idMax} AS CODIGO," +
                $"CODIGO AS ID_PRODUTO, VALOR AS VALOR, " +
                $"'{dataAtual}' AS DATA FROM PRODUTOS WHERE ID_PRODUTO = {idProd} ";

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

        public bool InsereTipoVenda(int id, char tipo_entrada)
        {
            DateTime dataAtual = DateTime.Today;
            string sql = $"INSERT INTO REL_TIPO_ENTRADA_CAIXA " +
                $"SELECT NULL AS CODIGO, " +
                $"'{dataAtual}' AS DATA, " +
                $"'{tipo_entrada}' AS TIPO_ENTRADA, " +
                $"SUM(VALOR) AS VALOR_TOTAL, " +
                $"CODIGO AS ID_VENDA FROM VENDAS WHERE CODIGO = {id} ";

            return BD.Insert(sql); 
        }
        
    }
}
