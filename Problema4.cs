using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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

            Console.Write("Digite o valor da taxa ao mês em porcentagem: ");
            decimal i = decimal.Parse(Console.ReadLine()); 
            i = i / 100m; // converter para decimal

            Console.Write("Digite quantos meses de investimento: ");
            int mes = int.Parse(Console.ReadLine());

            int mesResgate = 5;
            decimal valorResgate = 1000;

            for (int j = 1; j <= mes; j++)
            {
                decimal rendimento = p * i;
                decimal valorFuturo = p + rendimento;
                decimal resgate = 0;
                decimal saldoFinal = valorFuturo;

                if (j == mesResgate)
                {
                    resgate = valorResgate;
                    Console.WriteLine($"Realizando o resgate: {resgate:C} ");
                    saldoFinal = valorFuturo - resgate;
                    p = saldoFinal;
                }
                else
                {
                    p = valorFuturo;
                }

                Console.WriteLine($"Mês {j} | Rendimento: {rendimento:C} | Resgate: {resgate:C} | Saldo acumulado: {saldoFinal:C}");
            }
        }
    }
}

