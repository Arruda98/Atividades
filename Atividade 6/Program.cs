using System;

namespace Atividade2
{
    class Nome
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Quem vai apagar o quadro hoje");

            Console.WriteLine("Primeiro aluno: ");
            string primeiroAluno = Console.ReadLine();
            Console.WriteLine("Segundo aluno:");
            string segundoAluno = Console.ReadLine();
            Console.WriteLine("Terceiro aluno:");
            string terceiroAluno = Console.ReadLine();
            Console.WriteLine("Quarto aluno:");
            string quartoAluno = Console.ReadLine();

            List<string> alunos = new List<string> 
            { 
                primeiroAluno, segundoAluno, terceiroAluno, quartoAluno 
            };

            Random random = new Random();

            int indiceSorteado = random.Next(alunos.Count);

            Console.WriteLine($"O aluno escolhido foi o: {random}");
        }
    }
}