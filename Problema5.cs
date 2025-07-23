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
            decimal saldo = 2000m;
            decimal taxa = 0.02m;
            decimal objetivo = 7360.61m;
            int meses = 0;

            while (saldo < objetivo)
            {
                saldo *= (1 + taxa);
                meses++;
                Console.WriteLine($"Mês {meses}: R$ {saldo:F2}");
            }

            Console.WriteLine($"\nAlcançado em {meses} meses: R$ {saldo:F2}");
        }
    }
}
