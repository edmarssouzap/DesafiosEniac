using System;

namespace PagamentoOnline
{
    class Fisica : Pessoa
    {
        public string Cpf { get; set; }

        public Fisica (string Cpf) : base (Cpf)
        {
            this.Cpf = Cpf;
        }

        protected override Boolean validar(string documento)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            documento = documento.Trim();
            documento = documento.Replace(".", "").Replace("-", "");

            if (documento.Length != 11) return false;
            tempCpf = Cpf.Substring(0, 9);

            soma = 0;
            for (int i = 0; i < 9; i++) soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;

            if (resto < 2) resto = 0;
            else resto = 11 - resto;

            digito = resto.ToString();
            tempCpf += digito;

            soma = 0;
            for (int i = 0; i < 10; i++) soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2) resto = 0;
            else resto = 11 - resto;
            digito += resto.ToString();
            return Cpf.EndsWith(digito);
        }
    }
}
