using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequênciaDeFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
        // um dado número é o resultado da soma dos dois anteriores
        // 0 1 1 2 3 5 8 13 21 34 55 89 [...]

        Inicio:
            Console.Clear();

            int a = 0, b = 1, c = 0;

            Console.WriteLine("### SEQUÊNCIA DE FIBONACCI ###");

            Console.Write("Quantos valores da sequência deseja visualizar? ");
            int valores = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSequência de Ficonacci com " + valores + " valores.");

            for (int i = 0; i < valores; i++)
            {
                if (i < valores - 1)
                {
                    Console.Write(a + ", ");
                }
                else
                {
                    Console.WriteLine(a);
                }

                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine("\nDeseja continuar? (s / n)");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "s")
            {
                goto Inicio;
            }
            else
            {
                Console.WriteLine("\nAplicação encerrada");
                Console.WriteLine("Tecle para sair...");
            }
            Console.ReadKey();

        }
    }
}
