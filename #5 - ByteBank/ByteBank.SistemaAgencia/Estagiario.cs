using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.Modelos.Funcionarios
{
    class Estagiario : Funcionario
    {
        public Estagiario (double salario, string cpf) :base (salario, cpf) { }
        public override void AumentarSalario()
        {
            throw new NotImplementedException(); //criado automaticamente pelo VisualStudo
        }

        protected override double GetBonificacao()
        {
            throw new NotImplementedException();
        }
    }
}
