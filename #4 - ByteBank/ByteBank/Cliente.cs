using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Cliente
    {
        private string cpf;

        public string Nome { get; set; }
        public string CPF
        {
            get
            {
                return cpf;
            }
            set
            {
                cpf = value;
            }
        }
        public string Profissao { get; set; }
    }
}
