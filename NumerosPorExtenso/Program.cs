using Caelum.Stella.CSharp.Inwords;
using System.Diagnostics;

namespace NumerosPorExtenso
{
    public class Program
    {
        static void Main(string[] args)
        {
            double valor = 75;
            string extenso = new Numero(valor).Extenso();
            Debug.WriteLine(extenso);

            valor = 1532897;
            extenso = new Numero(valor).Extenso();
            Debug.WriteLine(extenso);

            string extensoBrl = new MoedaBRL(valor).Extenso();
            Debug.WriteLine(extensoBrl);

            valor = 1532897.89;
            extensoBrl = new MoedaBRL(valor).Extenso();
            Debug.WriteLine(extensoBrl);
        }
    }
}
