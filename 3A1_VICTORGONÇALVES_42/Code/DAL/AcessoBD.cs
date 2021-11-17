using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3A1_VICTORGONÇALVES_42.Code.DAL
{
    class AcessoBD
    {
        MySqlConnection conexao;

        public void Conectar()
        {
            try
            {
                string conn = "Persist Security Info = false; " +
                              "server = localhost; " +
                              "database = victor42BD; " +
                              "uid = root; pwd=;convert zero datetime=True";

                conexao = new MySqlConnection(conn);
                conexao.Open();
            }
            catch (MySqlException ex)
            {

                throw new Exception("Não foi possível conectar ao banco de dados.\n" + ex.Message);

            }
        }

        public DataTable ExecutarConsulta(string sql)       //sql é uma string que deve conter uma instrução Select
        {
            try
            {
                Conectar();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexao);
                DataTable dt = new DataTable();
                dados.Fill(dt);    //Preenchimento do objeto DataTable(dt) com os dados obtidos da execução do select

                return dt;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Não foi possível executar a CONSULTA solicitada.\n" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void ExecutarComando(string sql)     //sql: instrução sql de INSERT, UPDATE ou DELETE
        {
            Conectar();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();      //Método responsável por executar a instrução sql
            }
            catch (MySqlException ex)
            {
                throw new Exception("A instrução não foi realizada.\n" + ex.Message);
            }
            finally
            {
                conexao.Close();        //Importante para que o banco não fique vulnerável.
            }



        }
    }
}
