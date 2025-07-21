using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa2
{
    public class Problema3
    {
        public static void Exec()
        {
            Console.Write("Digite o valor presente: ");
            decimal p = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o valor da taxa ao ano em porcentagem: ");
            decimal i = decimal.Parse(Console.ReadLine());
            i = i / 100m;

            Console.Write("Digite quantos anos de investimento: ");
            int ano = int.Parse(Console.ReadLine()); ;
            
            decimal somaTaxa = i + 1;
            decimal fator = 1;

            for (int j = 1; j <= ano; j++)
            {
                fator *= somaTaxa;

            }
            decimal F = p * fator;

            Console.WriteLine($"o resultado valor futuro é : {F:C}");

        }
    }
}
