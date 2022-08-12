using System;

namespace PagamentoOnline
{
    abstract class Pessoa
    {
        public string Nome { get; set; }

        public Pessoa(string Nome)
        {
            this.Nome = Nome;
        }

        public void escreverNome()
        {
            Console.WriteLine("Seu nome é " + Nome);
        }

        abstract protected Boolean validar(string documento);
    }
}
