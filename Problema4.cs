using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa2
{
    public class Problema4
    {
        public static void Exec()
        {
            Console.Write("Digite o valor presente: ");
            decimal p = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o valor da taxa ao mes em porcentagem: ");
            decimal i = decimal.Parse(Console.ReadLine());
            i = i / 100m;

            Console.Write("Digite quantos meses de investimento: ");
            int mes = int.Parse(Console.ReadLine()); ;

            decimal somaTaxa = i + 1;
            decimal fator = 1;
            decimal Anterior = p;
            decimal saque = 0;

            for (int j = 1; j <= mes; j++)
            { 
                Console.Write("Deseja realizar saque? 1 para saque e 0 para continuar: ");
                int decisao = int.Parse(Console.ReadLine()); ;
                if (decisao == 1)
                {
                    Console.Write("Digite o valor do saque");
                    saque = decimal.Parse(Console.ReadLine());

                }
                fator *= somaTaxa;
                decimal F = p * fator;
                F = F - saque;
                decimal rendimentoMensal = F - Anterior;
                Anterior = F;

                Console.WriteLine($"mês {j} | rendimento: {F:C} | liquido: {rendimentoMensal:C}");

            }

        }

    }
    }
