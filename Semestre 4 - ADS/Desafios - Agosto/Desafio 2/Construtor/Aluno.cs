using System;

namespace Construtor
{
    class Aluno
    {
        public string Nome { get; private set; }
        private string Sobrenome { get; set; }
        private DateTime Nascimento { get; set; }
        public int Idade { get; private set; }

        public Aluno(string nome, string sobrenome, DateTime nascimento)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Nascimento = nascimento;

            var hoje = DateTime.Today;
            Idade = hoje.Year - nascimento.Year;
        }
    }
}
