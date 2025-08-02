using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TesteDeMesa2
{
    public class Problema5
    {
       public static void Exec()
       {
            decimal vf = 7390.61m;
            decimal taxaAnual = 0.02m;
            int anos = 2;
            decimal fator = 1;

            for (int j = 0; j < anos; j++)
            {
                fator *= (1 + taxaAnual);
            }

           decimal vp = vf / fator;

            Console.WriteLine($"Valor Futuro: {vf:C}");
            Console.WriteLine($"Taxa anual: {taxaAnual:P}");
            Console.WriteLine($"Tempo: {anos} anos");
            Console.WriteLine($"Fator (1 + i)^t: {fator:F6}");
            Console.WriteLine($"Valor Presente necessário: {vp:C}");
       }
    }
}