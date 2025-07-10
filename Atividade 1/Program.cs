using System;

namespace Atividade1
{
    class Chuva
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Está chovendo?");
            string primeiraResposta = Console.ReadLine();

            if (primeiraResposta == "Sim")
            {
                Console.WriteLine("Você tem um guarda-chuva?");
                string segundaResposta = Console.ReadLine();

                if (segundaResposta == "Sim")
                    Console.WriteLine("Saia!");

                else
                {
                    Console.WriteLine("Espere um pouco");

                    Thread.Sleep(2000);

                    Console.WriteLine("Está chovendo?");
                    var terceiraResposta = Console.ReadLine();

                    while (terceiraResposta != "Não")
                    {
                        Console.WriteLine("Espere um pouco.");

                        Thread.Sleep(2000);

                        Console.WriteLine("Está chovendo?");
                        terceiraResposta = Console.ReadLine();

                    }
                    Console.WriteLine("Saia!");
                }
            }
            else
                Console.WriteLine("Saia!");
        }
    }
    

}