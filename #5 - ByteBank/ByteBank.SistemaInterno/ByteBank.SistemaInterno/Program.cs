using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2022, 12, 15);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions(diferenca);
            Console.WriteLine(mensagem);
            Console.WriteLine(dataFimPagamento);
            Console.WriteLine(dataCorrente);



            Console.ReadLine();
        }
       
    }
}
