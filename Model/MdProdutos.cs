using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
