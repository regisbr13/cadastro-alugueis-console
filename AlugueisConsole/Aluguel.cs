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
    }
}
