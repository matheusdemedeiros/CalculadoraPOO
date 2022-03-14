using System;

namespace CalculadoraPOO.ConsoleApp
{
    public class Util
    {
        public static bool VerificaSeUmaStringEhUmNumeroDouble(string entrada)
        {
            return double.TryParse(entrada, out double valorConvertido);
        }

        public static bool VerificaSeUmaStringEhUmNumeroInteiro(string entrada)
        {
            return double.TryParse(entrada, out double valorConvertido);
        }

        public static int VerificaSeUmValorPertenceAhUmIntervaloDeInteiros(int valor, int inicioIntervalo, int fimIntervalo)
        {
            if (valor >= inicioIntervalo && valor <= fimIntervalo)
                return valor;
            else
                return int.MinValue;
        }

        public static double VerificaSeUmValorDoubleEhZero(double valor)
        {
            return valor == 0 ? double.MinValue : valor;
        }

        public static string ApresentaUmDoubleComDuasCasasDecimais(double valor)
        {
            return valor.ToString("F2");
        }

    }
}
