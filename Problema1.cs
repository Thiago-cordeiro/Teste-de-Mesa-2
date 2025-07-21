using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa2
{
    public class Problema1
    {
        public static void Exec()
        {
            decimal p = 1000;
            decimal i = 0.053m;
            int mes = 6;
            decimal somaTaxa = i + 1;
            decimal fator = 1;

            for (int j = 1; j <= mes; j++)
            {
                fator *= somaTaxa;
                
            }
            decimal F = p * fator;

            Console.WriteLine($"o resultado valor futuro é : {F:C}");
        }
    }
}
