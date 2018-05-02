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
            Console.Write("Quantos aluguéis serão registrados (1 a " + qteQuartos + ")? ");
            int qteAlugueis = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qteAlugueis; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Dados do " + i + "° aluguel:");
                Console.Write("Nome: ");
                string hospede = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());
                Aluguel aluguel = new Aluguel(hospede, email, numeroQuarto);
                 alugueis[i - 1] = aluguel;
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < qteQuartos; i++)
            {
                if (alugueis[i] != null)
                {
                    Console.WriteLine(alugueis[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
