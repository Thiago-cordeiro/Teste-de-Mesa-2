using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa2
{
    public class Problema2
    {
        public static void Exec()
        {
            decimal p = 3800;
            decimal i = 0.0125m;
            int mes = 6;
            decimal somaTaxa = i + 1;
            decimal fator = 1;
            decimal Anterior = p;
            decimal liquido = 0;

            for (int j = 1; j <= mes; j++)
            {
                fator *= somaTaxa;
                decimal F = p * fator;
                decimal rendimentoMensal = F - Anterior;
                liquido += rendimentoMensal;
                Anterior = F;

                Console.WriteLine($"mês {j} | rendimento: {F:C} | liquido: {rendimentoMensal:C} | liquido: {liquido:C}");
            }

        }
    }
}
