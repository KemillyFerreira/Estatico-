using System;

namespace Estaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            float valor = 1f;

            //chamando a classe estática sem instânciar
            Console.WriteLine($"{valor} Dólar   = {Conversor.DolarParaReal(valor)} Reais");
            Console.WriteLine($"{valor} Real    = {Conversor.RealParaDolar(valor):0.00} Dólar");
            Console.WriteLine($"{valor} Euro    = {Conversor.EuroParaReal(valor)} Reais");
            Console.WriteLine($"{valor} Real    = {Conversor.RealParaEuro(valor):0.00} Euro");

            Console.WriteLine($"2^4 = {Math.Pow(2, 4)}");
        }
    }
}
