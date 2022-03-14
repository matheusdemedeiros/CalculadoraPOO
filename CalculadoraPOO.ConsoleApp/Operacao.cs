using System;

namespace CalculadoraPOO.ConsoleApp
{
    public class Operacao
    {
        public double valor1;
        public double valor2;
        public double resultado;
        public string operador;

        public string RetornarOperacao()
        {
            return "\n" + Util.ApresentaUmDoubleComDuasCasasDecimais(valor1) + " " + operador + " " + Util.ApresentaUmDoubleComDuasCasasDecimais(valor2)
                + " = " + Util.ApresentaUmDoubleComDuasCasasDecimais(resultado);
        }
    }
}