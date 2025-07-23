using System;

namespace TesteDeMesa2
{

    class program
    {
        static void Main(string[] args)
        {
            string escolha;
            do
            {
                Console.WriteLine("\nEscolha um exercício (1, 2, 3, 4, 5) ou 0 para sair:");
                escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Problema1.Exec();
                        break;
                    case "2":
                        Problema2.Exec();
                        break;
                    case "3":
                        Problema3.Exec();
                        break;
                    case "4":
                        Problema4.Exec();
                        break;
                    case "5":
                        Problema5.Exec();
                        break;
                    case "0":
                        Console.WriteLine("Ssaindoo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

            } while (escolha != "0");
        }
    }
}
