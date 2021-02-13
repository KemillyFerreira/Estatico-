using System;

namespace Estaticos
{
    public class Conversor
    {
        private static float cotacaoDolar = 5.07f;
        private static float cotacaoEuro  = 6.16f;



        public static float RealParaDolar(float valorRS)
        {
            return valorRS / cotacaoDolar;
        }

        public static float DolarParaReal(float valorRS)
        {
            return valorRS * cotacaoDolar;
        }

        public static float RealParaEuro(float valorRS)
        {
            return valorRS / cotacaoEuro;
        }

        public static float EuroParaReal(float valorEuro)
        {
            return valorEuro * cotacaoEuro;
        }
    }
}