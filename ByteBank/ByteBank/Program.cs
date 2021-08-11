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
                ContaCorrente conta1 = new ContaCorrente(111, 222);
                ContaCorrente conta2 = new ContaCorrente(333, 444);

                conta2.Transferir(10, conta1);

                Console.WriteLine("1 "+conta1.Saldo);
                Console.WriteLine("2 "+conta2.Saldo);



            }
            catch(ArgumentException e)
            {
                if(e.ParamName == "numero")
                {

                }
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ParamName);
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine("Mensagem: "+e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }






            Console.WriteLine("\n\n\n");
            Console.WriteLine("========================");
            Console.WriteLine("|| PROGRAMA ENCERRADO ||");
            Console.WriteLine("========================");
            Console.ReadLine();
        }
    }
}
