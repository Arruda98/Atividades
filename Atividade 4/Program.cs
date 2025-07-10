using System;

namespace Atividade4
{
    class calculo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Me fale um número: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Me fala outro número: ");
            double b = double.Parse(Console.ReadLine());

            double x = a + b;

            Console.WriteLine($"A soma entre {a} e {b} é igua à {x}");
        }
    }
}