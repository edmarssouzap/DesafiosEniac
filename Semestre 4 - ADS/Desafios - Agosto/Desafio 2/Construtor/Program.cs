using System;

namespace Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno("Pedro", "Silva", new DateTime(1991, 10, 10));
            Console.WriteLine("Desafio\n\nA idade de {0} é de {1} anos.", aluno.Nome, aluno.Idade);
            Console.ReadKey();
        }
    }
}
