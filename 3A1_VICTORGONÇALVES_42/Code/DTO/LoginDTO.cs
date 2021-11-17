using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3A1_VICTORGONÇALVES_42.Code.DTO
{
    class LoginDTO
    {
        private int _id;
        private string _email;
        private string _senha;

        public int Id { get => _id; set => _id = value; }
        public string Email { get => _email; set => _email = value; }
        public string Senha { get => _senha; set => _senha = value; }

    }
}
