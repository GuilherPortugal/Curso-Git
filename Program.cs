using System;

namespace FunçõesParaString
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Quantos quartos serão alugados");
            int n = int.Parse(Console.ReadLine());
            Alunos[] al = new Alunos[10];
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Alugel " + i + " : ");
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Quarto: ");
                int qtdquarto = int.Parse(Console.ReadLine());
                al[qtdquarto] = new Alunos(nome, email);
            }

            Console.WriteLine();

            Console.WriteLine("Quartos Ocupados");

            for (int i = 0; i < 10; i++)
            {
                if (al[i] != null)
                {
                    Console.WriteLine(i + ": " + al[i]);
                }
            }
        }
    }
}
