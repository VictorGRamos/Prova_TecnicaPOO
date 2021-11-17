using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3A1_VICTORGONÇALVES_42.Code.DAL;
using _3A1_VICTORGONÇALVES_42.Code.DTO;
using System.Data;

namespace _3A1_VICTORGONÇALVES_42.Code.BLL
{
    class LoginBLL
    {
        

        AcessoBD conexao = new AcessoBD();
        string tabela = "tbl_login";
        public bool RealizarLogin(LoginDTO loginDTO)
        {
            string sql = $"select * from {tabela} where nomeusuario = '{loginDTO.Email}' and senha = '{loginDTO.Senha}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;

        }
             
        

    }
}
