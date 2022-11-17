using Caelum.Stella.CSharp.Http;
using System.Diagnostics;
using System.Net.Http;

namespace CEP
{
    public class Program
    {
        static void Main(string[] args)
        {
            string cep = "01001000";
            string result = GetEndereco(cep);

            Debug.WriteLine(result);

            ViaCEP viaCEP = new ViaCEP();
            string enderecoJson = viaCEP.GetEnderecoJson(cep);
            Debug.WriteLine(enderecoJson);

            string enderecoXml = viaCEP.GetEnderecoXml(cep);
            Debug.WriteLine(enderecoXml);

            var task = viaCEP.GetEnderecoJsonAsync(cep);
            Debug.WriteLine(task.Result);

            var endereco = viaCEP.GetEndereco(cep);
            Debug.WriteLine(string.Format($"Logradouro: {0}, Bairro: {1}"));
        }

        private static string GetEndereco(string cep)
        {
            return "https://viacep.com.br/ws/" + cep + "/json/";
        }
    }
}
