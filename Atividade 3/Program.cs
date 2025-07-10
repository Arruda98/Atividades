using System;

namespace Atividade3
{
    class Nome
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Qual é o dia em que você nasceu?");
            var dia = Console.ReadLine();

            Console.WriteLine("Qual é o mês em que você nasceu?");
            var mes = Console.ReadLine();

            Console.WriteLine("Qual é o ano em que você nasceu?");
            var ano = Console.ReadLine();

            Console.WriteLine($"Você nasceu no dia {dia} de {mes} de {ano}, Correto?");
        }
    }
}