using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Bogus.DataSets;

namespace ConversaoMoedas
{
    public class Program
    {
        static void Main(string[] args)
        {
            decimal qtdBRL, valorUSD, valorEUR, valorJPY, valorGBP, convertidorBRL;
            int op;

            Console.WriteLine("----------Bem vindo ao conversor de moedas!!---------");

            Console.WriteLine("Digite aqui o valor que você deseja converter em Real:");
            qtdBRL = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite {1} para converter em Dolar.");
            Console.WriteLine("Digite {2} para converter em Euro.");
            Console.WriteLine("Digite {3} para converter em Iene");
            Console.WriteLine("Digite {4} para converter em Libra");
            op = Convert.ToInt32(Console.ReadLine());

            if (op == 1)
            {
                Console.WriteLine("Quanto está valendo o dolar?");
                valorUSD = decimal.Parse(Console.ReadLine());

                convertidorBRL = qtdBRL / valorUSD;

                Console.WriteLine("A conversão de R$" + qtdBRL + "é:" + "$" + convertidorBRL);

            }
            else if (op == 2)
            {
                    Console.WriteLine("Quanto está valendo o Euro?");
                    valorEUR = decimal.Parse(Console.ReadLine());

                    convertidorBRL = qtdBRL / valorEUR;

                    Console.WriteLine("A conversão de R$" + qtdBRL + "é:" + "$" + convertidorBRL);
            }
            else if (op == 3)
            {
                Console.WriteLine("Quanto está valendo o Iene?");
                valorJPY = decimal.Parse(Console.ReadLine());

                convertidorBRL = qtdBRL / valorJPY;

                Console.WriteLine("A conversão de R$" + qtdBRL + "é:" + "$" + convertidorBRL);
            }
            else if (op == 4)
            {
                Console.WriteLine("Quanto está valendo o Euro?");
                valorGBP = decimal.Parse(Console.ReadLine());

                convertidorBRL = qtdBRL / valorGBP;

                Console.WriteLine("A conversão de R$" + qtdBRL + "é:" + "$" + convertidorBRL);
            }

            else if(op > 4)
            {
                Console.WriteLine("Opção Inválida");
            }
            
        }
    }
}
