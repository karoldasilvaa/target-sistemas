using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Calculadora
{
    public class Dado
    {
        public int dia { get; set; }
        public decimal valor { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string json = "[{\"dia\":1,\"valor\":22174.1664},{\"dia\":2,\"valor\":24537.6698},{\"dia\":3,\"valor\":26139.6134},{\"dia\":4,\"valor\":0.0},{\"dia\":5,\"valor\":0.0},{\"dia\":6,\"valor\":26742.6612},{\"dia\":7,\"valor\":0.0},{\"dia\":8,\"valor\":42889.2258},{\"dia\":9,\"valor\":46251.174},{\"dia\":10,\"valor\":11191.4722},{\"dia\":11,\"valor\":0.0},{\"dia\":12,\"valor\":0.0},{\"dia\":13,\"valor\":3847.4823},{\"dia\":14,\"valor\":373.7838},{\"dia\":15,\"valor\":2659.7563},{\"dia\":16,\"valor\":48924.2448},{\"dia\":17,\"valor\":18419.2614},{\"dia\":18,\"valor\":0.0},{\"dia\":19,\"valor\":0.0},{\"dia\":20,\"valor\":35240.1826},{\"dia\":21,\"valor\":43829.1667},{\"dia\":22,\"valor\":18235.6852},{\"dia\":23,\"valor\":4355.0662},{\"dia\":24,\"valor\":13327.1025},{\"dia\":25,\"valor\":0.0},{\"dia\":26,\"valor\":0.0},{\"dia\":27,\"valor\":25681.8318},{\"dia\":28,\"valor\":1718.1221},{\"dia\":29,\"valor\":13220.495},{\"dia\":30,\"valor\":8414.61}]";
            List<Dado> dados = JsonConvert.DeserializeObject<List<Dado>>(json);

            decimal menorValor = MenorValor(dados);
            decimal maiorValor = MaiorValor(dados);
            decimal diasMaiorMedia = QuantidadeDiasMaiorMedia(dados);

            Console.WriteLine($"O menor valor é: {menorValor}");
            Console.WriteLine($"O maior valor é: {maiorValor}");
            Console.WriteLine($"Quantidade de dias maior do que a média: {diasMaiorMedia}");

            Console.ReadKey();
        }

        static decimal MenorValor(List<Dado> dados)
        {
            return dados.OrderBy(x => x.valor).FirstOrDefault().valor;
        }

        static decimal MaiorValor(List<Dado> dados)
        {
            return dados.OrderBy(x => x.valor).LastOrDefault().valor;
        }

        static int QuantidadeDiasMaiorMedia(List<Dado> dados)
        {
            decimal total = 0;
            int dias = 0;

            foreach (var item in dados)
            {
                if (item.valor > 0)
                {
                    dias += 1;
                    total += item.valor;
                }
            }

            decimal media = total / dias;

            int diasMaiorMedia = 0;

            foreach (var item in dados)
            {
                if (item.valor > media)
                {
                    diasMaiorMedia += 1;
                }
            }

            return diasMaiorMedia;
        }
    }
}