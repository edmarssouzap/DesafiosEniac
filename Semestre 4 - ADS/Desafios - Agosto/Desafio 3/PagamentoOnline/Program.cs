using System;

namespace PagamentoOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            Fisica pf = new Fisica("111.111.111-12");
            pf.Nome = "Edmar";
            pf.validar(pf.Cpf);
            pf.escreverNome();

            Juridica jd = new Juridica("111.111.122-22");
            jd.Nome = "Ed Software LTDA.";
            jd.validar(jd.Cnpj);
            jd.escreverNome();

            Console.ReadKey();
        }
    }
}
