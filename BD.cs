using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace EmporioRoyal
{
    internal class BD
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source=C:\\gitprojects\\RealEmporio\\bd\\bd_emporio.db");
            conexao.Open();
            return conexao;
        }

        public static DataTable ObterTodosUsuarios()
        {

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM USUARIOS";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {

                throw ex;

            }
        }

        public static DataTable Consulta(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;

            }
        }

        public static bool Insert(string sql)
        {
            // string sql = $"INSERT INTO CLIENTES (NOME, TELEFONE, WPP, ENDERECO, BAIRRO, ATIVO) VALUES ('{Nome}', '{Telefone}', '{Wpp}', '{Endereco}', '{Bairro}', '{Ativo}')";
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    ConexaoBanco().Close();
                    return true; // Inserção bem-sucedida
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                MessageBox.Show("Erro ao inserir cliente: " + ex.Message);
                return false; // Falha na inserção
            }
        }

        public static bool Update(string sql)
        {
            // string sql = $"INSERT INTO CLIENTES (NOME, TELEFONE, WPP, ENDERECO, BAIRRO, ATIVO) VALUES ('{Nome}', '{Telefone}', '{Wpp}', '{Endereco}', '{Bairro}', '{Ativo}')";
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    ConexaoBanco().Close();
                    return true; // Inserção bem-sucedida
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                MessageBox.Show("Erro ao inserir cliente: " + ex.Message);
                return false; // Falha na inserção
            }
        }

        public static bool Delete(string sql)
        {
            // string sql = $"INSERT INTO CLIENTES (NOME, TELEFONE, WPP, ENDERECO, BAIRRO, ATIVO) VALUES ('{Nome}', '{Telefone}', '{Wpp}', '{Endereco}', '{Bairro}', '{Ativo}')";
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    ConexaoBanco().Close();
                    return true; // Inserção bem-sucedida
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                MessageBox.Show("Erro ao inserir cliente: " + ex.Message);
                return false; // Falha na inserção
            }
        }
    }
}
