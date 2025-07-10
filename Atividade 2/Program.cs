using System;

namespace Atividade2
{
    class Nome
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("Qual é o seu nome?");
            var nome = Console.ReadLine();

            Console.WriteLine($"Olá {nome}, prazer em te conhecer!");
        }
    }
}