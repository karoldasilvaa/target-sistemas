using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Calculadora
{
    public class Distrubuidora
    {
        public string UF { get; set; }
        public decimal Faturamento { get; set; }

        public decimal Porcentagem { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Distrubuidora> distribuidoras = new List<Distrubuidora>();
            distribuidoras.Add(new Distrubuidora { UF = "SP", Faturamento = 67836.43m });
            distribuidoras.Add(new Distrubuidora { UF = "RJ", Faturamento = 36678.66m });
            distribuidoras.Add(new Distrubuidora { UF = "MG", Faturamento = 29229.88m });
            distribuidoras.Add(new Distrubuidora { UF = "ES", Faturamento = 27165.48m });
            distribuidoras.Add(new Distrubuidora { UF = "Outros", Faturamento = 19848.53m });

            decimal total = distribuidoras.Sum(x => x.Faturamento);

            foreach (var item in distribuidoras)
            {
                item.Porcentagem = (item.Faturamento / total * 100);

                Console.WriteLine($" O estado {item.UF} representa {item.Porcentagem}% do valor total mensal da distribuidora.");
            }

            Console.ReadKey();
        }
    }
}