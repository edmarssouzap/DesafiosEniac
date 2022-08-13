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
            Console.WriteLine("Seu nome/Razao Social é " + Nome);
        }

        abstract public Boolean validar(string documento);
    }
}
