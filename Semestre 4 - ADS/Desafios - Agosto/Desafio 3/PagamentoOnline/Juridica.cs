using System;

namespace PagamentoOnline
{
    class Juridica : Pessoa
    {
        public string Cnpj { get; set; }
        
        public Juridica(string Cnpj) : base (Cnpj)
        {
            this.Cnpj = Cnpj;
        }

        protected override Boolean validar(string documento)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            documento = documento.Trim();
            documento = documento.Replace(".", "").Replace("-", "").Replace("/", "");

            if (documento.Length != 14) return false;
            tempCnpj = documento.Substring(0, 12);

            soma = 0;
            for (int i = 0; i < 12; i++) soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);
            if (resto < 2) resto = 0;
            else resto = 11 - resto;

            digito = resto.ToString();
            tempCnpj += digito;

            soma = 0;
            for (int i = 0; i < 13; i++) soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            if (resto < 2) resto = 0;
            else resto = 11 - resto;

            digito += resto.ToString();
            return documento.EndsWith(digito);
        }
    }
}
