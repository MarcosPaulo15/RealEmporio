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
    }
}
