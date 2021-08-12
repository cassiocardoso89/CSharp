using System;
using System.Collections.Generic;
using System.IO;
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
            CarregarContas();
            }
            catch(Exception)
            {
                Console.WriteLine("CATCH no MAIN");
            }


            Console.WriteLine("\n\n\n");
            Console.WriteLine("========================");
            Console.WriteLine("|| PROGRAMA ENCERRADO ||");
            Console.WriteLine("========================");
            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
            {
                //IDisposible é uma interface
                leitor.LerProximaLinha();
            }


            //==============================================//
            //LeitorDeArquivo leitor = null;
            //try
            //{
            //    leitor = new LeitorDeArquivo("CarregarContas5.txt");
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Excessao do tipo IOException, capturada e tratada");
            //}
            //finally
            //{
            //    Console.WriteLine("to no finally");
            //    if (leitor != null)
            //    {
            //    leitor.Fechar();
            //    }
            //}
        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(111, 333);
                ContaCorrente conta2 = new ContaCorrente(222, 444);

                //conta1.Transferir(100000, conta2);
                conta1.Sacar(100000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                //Console.WriteLine("InnerException:\n" + e.InnerException.Message);
                //Console.WriteLine("InnerException:\n" + e.InnerException.StackTrace);
            }
        }
    }
}
