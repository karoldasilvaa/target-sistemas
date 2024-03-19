using Newtonsoft.Json;
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
            string nome = "Karoline";
            string nomeInvertido = "";
            string[] letras = new string[nome.Length];

            for (int i = 0; i < nome.Length; i++)
            {
                letras[i] = nome.Substring(i, 1);
            }

            for (int i = nome.Length; i > 0; i--)
            {
                nomeInvertido += letras[i - 1];
            }

            Console.WriteLine(nomeInvertido);
            Console.ReadKey();
        }
    }
}