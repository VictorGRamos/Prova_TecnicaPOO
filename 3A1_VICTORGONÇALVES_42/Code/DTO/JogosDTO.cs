using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3A1_VICTORGONÇALVES_42.Code.DTO
{
    class JogosDTO
    {
        private int _id;
        private string _nomejogo;
        private double _preco;
        private int _quantidade;

        public string Nomejogo { get => _nomejogo; set => _nomejogo = value; }
        public double Preco { get => _preco; set => _preco = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }
        public int Id { get => _id; set => _id = value; }
    }
}
