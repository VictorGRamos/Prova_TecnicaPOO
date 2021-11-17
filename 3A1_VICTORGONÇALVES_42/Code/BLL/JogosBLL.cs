using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using _3A1_VICTORGONÇALVES_42.Code.DAL;
using _3A1_VICTORGONÇALVES_42.Code.DTO;


namespace _3A1_VICTORGONÇALVES_42.Code.BLL
{
    class JogosBLL
    {
        AcessoBD conexao = new AcessoBD();
        string tabela = "tbl_estoque";


        public void Inserir(JogosDTO jogosDTO)
        {
            string inserir = $"insert into {tabela} value (null, '{jogosDTO.Nomejogo}', '{jogosDTO.Preco}', '{jogosDTO.Quantidade}')";
            conexao.ExecutarComando(inserir);
        }

        public void Editar(JogosDTO jogosDTO)
        {
            string alterar = $"update {tabela} set nomejogo = '{jogosDTO.Nomejogo}', preco = '{jogosDTO.Preco}'," +
                $"quantidade = '{jogosDTO.Quantidade}' where id = '{jogosDTO.Id}'";
            conexao.ExecutarComando(alterar);
        }

        public void Exclui(JogosDTO jogosDTO)
        {
            string excluir = $"delete from {tabela} where id = '{jogosDTO.Id}' ";
            conexao.ExecutarComando(excluir);
        }

        /*
          public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }
         */

        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }



    }
}
