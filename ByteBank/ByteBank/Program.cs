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
            try
            {
                ContaCorrente conta1 = new ContaCorrente(111, 333);
                ContaCorrente conta2 = new ContaCorrente(222, 444);

                //conta1.Transferir(100000, conta2);
                conta1.Sacar(100000);
            }
            catch(OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                //Console.WriteLine("InnerException:\n" + e.InnerException.Message);
                //Console.WriteLine("InnerException:\n" + e.InnerException.StackTrace);
            }




            Console.WriteLine("\n\n\n");
            Console.WriteLine("========================");
            Console.WriteLine("|| PROGRAMA ENCERRADO ||");
            Console.WriteLine("========================");
            Console.ReadLine();
        }
    }
}
