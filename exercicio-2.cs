using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número");
            int numero = Convert.ToInt32(Console.ReadLine());

            bool resultado = Fibonacci(numero);

            if (resultado)
            {
                Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
            }

            Console.ReadKey();
        }

        static bool Fibonacci(int numero)
        {
            if (numero <= 3)
            {
                return true;
            }

            int[] sequencia = new int[numero+1];

            sequencia[0] = 0;
            sequencia[1] = 1;

            for (int i = 2; i <= numero; i++)
            {
                sequencia[i] = sequencia[i-1] + sequencia[i-2];                

                if (sequencia[i] >= numero)
                {
                    break;
                }
            }

            return sequencia.Contains(numero);
        }
    }
}