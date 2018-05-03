using System;

namespace AlugueisConsole
{
    class Aluguel
    {
        public string Hospede { get; set; }
        public string Email { get; set; }
        public int Numero { get; set; }

        public Aluguel(string hospede, string email, int numero)
        {
            this.Hospede = hospede;
            this.Email = email;
            this.Numero = numero;
        }

        public bool QuartoOcupado(int numero, Aluguel[] alugueis)
        {
            for (int i = 0; i < alugueis.Length; i++)
            {
                if (alugueis[i] != null && alugueis[i].Numero == numero)
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return Numero + ": " + Hospede + ", " + Email;
        }
    }
}
