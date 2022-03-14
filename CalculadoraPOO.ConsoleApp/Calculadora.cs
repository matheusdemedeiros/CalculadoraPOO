using System;

namespace CalculadoraPOO.ConsoleApp
{

    public class Calculadora
    {
        Operacao[] operacoes = new Operacao[100];

        public double Somar(double valor1, double valor2)
        {
            double resultado = valor1 + valor2;

            Operacao operacao = new Operacao();
            operacao.valor1 = valor1;
            operacao.valor2 = valor2;
            operacao.resultado = resultado;
            operacao.operador = "+";
            operacoes[RetornaAhPosicaoLivreDeUmArrayDeOperacoes()] = operacao;
            return resultado;
        }

        public double Subtrair(double valor1, double valor2)
        {
            double resultado = valor1 - valor2;

            Operacao operacao = new Operacao();
            operacao.valor1 = valor1;
            operacao.valor2 = valor2;
            operacao.resultado = resultado;
            operacao.operador = "-";
            operacoes[RetornaAhPosicaoLivreDeUmArrayDeOperacoes()] = operacao;

            return resultado;
        }

        public double Multiplicar(double valor1, double valor2)
        {
            double resultado = valor1 * valor2;

            Operacao operacao = new Operacao();
            operacao.valor1 = valor1;
            operacao.valor2 = valor2;
            operacao.resultado = resultado;
            operacao.operador = "*";
            operacoes[RetornaAhPosicaoLivreDeUmArrayDeOperacoes()] = operacao;

            return resultado;
        }

        public double Dividir(double valor1, double valor2)
        {
            double resultado = valor1 / valor2;

            Operacao operacao = new Operacao();
            operacao.valor1 = valor1;
            operacao.valor2 = valor2;
            operacao.resultado = resultado;
            operacao.operador = "/";
            operacoes[RetornaAhPosicaoLivreDeUmArrayDeOperacoes()] = operacao;

            return resultado;
        }

        private int RetornaAhPosicaoLivreDeUmArrayDeOperacoes()
        {
            int retorno = -1;

            for (int i = 0; i < operacoes.Length; i++)
            {
                if (operacoes[i] == null)
                {
                    retorno = i;
                    break;
                }
            }
            return retorno;
        }

        public void ApresentarHistoricoDeOperacoes()
        {
            int posicaoLivre = RetornaAhPosicaoLivreDeUmArrayDeOperacoes();

            if (posicaoLivre == 0)
            {
                Console.WriteLine("\nAinda não foram realizadas operações com esta calculadora!!\n");
                return;
            }
            else
            {
                for (int i = 0; i < posicaoLivre; i++)
                {
                    if (operacoes[i].operador == "+")
                    {

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine(operacoes[i].RetornarOperacao());

                        Console.ResetColor();
                    }
                    else if (operacoes[i].operador == "-")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine(operacoes[i].RetornarOperacao());

                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;

                        Console.WriteLine(operacoes[i].RetornarOperacao());

                        Console.ResetColor();
                    }
                }
            }
        }
    }
}
