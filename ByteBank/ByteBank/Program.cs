using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente(777, 999999);
            Console.WriteLine(ContaCorrente.TaxaOperacao);

            Console.ReadLine();
        }
    }
}
