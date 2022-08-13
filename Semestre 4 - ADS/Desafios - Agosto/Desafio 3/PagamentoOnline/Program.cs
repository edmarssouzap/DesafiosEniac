using System;

namespace PagamentoOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            Fisica pf = new Fisica("502.817.490-35");
            pf.Nome = "Edmar";
            pf.escreverNome();
            Console.WriteLine("Cpf é valido: " + pf.validar(pf.Cpf));

            Console.WriteLine("\n");

            Juridica jd = new Juridica("68.202.967/0001-90");
            jd.Nome = "Ed Software LTDA.";
            jd.escreverNome();
            Console.WriteLine("Cnpj é valido: " + jd.validar(jd.Cnpj));

            Console.ReadKey();
        }
    }
}
