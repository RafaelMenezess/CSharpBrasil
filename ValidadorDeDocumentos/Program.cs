using Caelum.Stella.CSharp.Format;
using Caelum.Stella.CSharp.Validation;
using System.Diagnostics;

namespace ValidadorDeDocumentos
{
    public class Program
    {
        static void Main(string[] args)
        {
            string cpf1 = "86288366757";
            string cpf2 = "98745366797";
            string cpf3 = "22222222222";

            ValidarCPF(cpf1);
            ValidarCPF(cpf2);
            ValidarCPF(cpf3);

            string cnpj1 = "51241758000152";
            string cnpj2 = "14128481000127";

            ValidarCNPJ(cnpj1);
            ValidarCNPJ(cnpj2);

            string titulo1 = "041372570132";
            string titulo2 = "774387480132";

            ValidarTitulo(titulo1);
            ValidarTitulo(titulo2);

            Debug.WriteLine(cpf1);
            string cpfFormatado = new CPFFormatter().Format(cpf1);
            Debug.WriteLine(cpfFormatado);
            Debug.WriteLine(new CPFFormatter().Unformat(cpfFormatado));

            Debug.WriteLine(cnpj1);
            string cnpjFormatado = new CNPJFormatter().Format(cnpj1);
            Debug.WriteLine(cnpjFormatado);
            Debug.WriteLine(new CNPJFormatter().Unformat(cnpjFormatado));

            Debug.WriteLine(titulo1);
            string tituloFormatado = new TituloEleitoralFormatter().Format(titulo1);
            Debug.WriteLine(tituloFormatado);
            Debug.WriteLine(new TituloEleitoralFormatter().Unformat(tituloFormatado));
        }

        private static void ValidarTitulo(string titulo)
        {
            if (new TituloEleitoralValidator().IsValid(titulo))
            {
                Debug.WriteLine("Título válido: " + titulo);
            }
            else
            {
                Debug.WriteLine("Título inválido: " + titulo);
            }
        }

        private static void ValidarCNPJ(string cnpj)
        {
            if (new CNPJValidator().IsValid(cnpj))
            {
                Debug.WriteLine("Cnpj válido: " + cnpj);
            }
            else
            {
                Debug.WriteLine("Cnpj inválido: " + cnpj);
            }
        }

        private static void ValidarCPF(string cpf)
        {
            if (new CPFValidator().IsValid(cpf))
            {
                Debug.WriteLine("CPF válido: " + cpf);
            }
            else
            {
                Debug.WriteLine("CPF inválido: " + cpf);
            }
        }
    }
}
