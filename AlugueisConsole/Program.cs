using System;

namespace AlugueisConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a quantidade de quartos disponíveis para alugar? ");
            int qteQuartos = int.Parse(Console.ReadLine());
            Aluguel[] alugueis = new Aluguel[qteQuartos];

            Console.WriteLine();
            Console.Write("Quantos aluguéis serão registrados? (1 - " + qteQuartos + ")");
            int qteAlugueis = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qteAlugueis; i++)
            {
                Console.WriteLine("Dados do " + i + "° aluguel:");
                Console.Write("Nome: ");
                string hospede = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());
                alugueis[i - 1] = new Aluguel(hospede, email, numeroQuarto);
            }
        }
    }
}
