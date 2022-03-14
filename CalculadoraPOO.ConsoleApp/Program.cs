using System;

namespace CalculadoraPOO.ConsoleApp
{
    public class Program
    {

        #region Variáveis
        static bool programaContinuaRepetindo = true;

        static string valor1 = "", valor2 = "";
        #endregion

        static void Main(string[] args)
        {
            MenuPrincipal menu = new MenuPrincipal();

            Calculadora calculadora = new Calculadora();

            while (programaContinuaRepetindo)
            {
                int opcaoDoUsuario = menu.ApresentarMenuEhRetornaAhOpcaoSelecionada();

                switch (opcaoDoUsuario)
                {
                    case int.MaxValue:
                        Console.WriteLine("\nEntrada inválida!!\nDigite apenas números!\n");
                        break;

                    case int.MinValue:
                        Console.WriteLine("\nO número informado não é uma opção válida!!\nDigite apenas números de 0 a 4!\n");
                        break;

                    case 0:
                        Console.WriteLine("\nVocê escolheu sair do sistema!!\n");
                        SairDoSistema();
                        break;
                    case 1:

                        Console.WriteLine("\n===== SOMANDO DOIS VALORES =====");

                        PedeDoisValoresAoUsuario();

                        if (Util.VerificaSeUmaStringEhUmNumeroDouble(valor1) && Util.VerificaSeUmaStringEhUmNumeroDouble(valor2))
                        {
                            double v1 = double.Parse(valor1);
                            double v2 = double.Parse(valor2);

                            Console.Write("\nResultado: {0}\n", (Util.ApresentaUmDoubleComDuasCasasDecimais(calculadora.Somar(v1, v2))));
                        }
                        else
                            Console.WriteLine("\nAlguma das entradas é inválida!!\n");

                        ResetarValores();

                        break;

                    case 2:

                        Console.WriteLine("\n===== SUBTRAINDO DOIS VALORES =====");

                        PedeDoisValoresAoUsuario();

                        if (Util.VerificaSeUmaStringEhUmNumeroDouble(valor1) && Util.VerificaSeUmaStringEhUmNumeroDouble(valor2))
                        {
                            double v1 = double.Parse(valor1);
                            double v2 = double.Parse(valor2);

                            Console.Write("\nResultado: {0}\n", (Util.ApresentaUmDoubleComDuasCasasDecimais(calculadora.Subtrair(v1, v2))));
                        }
                        else
                            Console.WriteLine("\nAlguma das entradas é inválida!!\n");

                        ResetarValores();

                        break;

                    case 3:

                        Console.WriteLine("\n===== MULTIPLICANDO DOIS VALORES =====");

                        PedeDoisValoresAoUsuario();

                        if (Util.VerificaSeUmaStringEhUmNumeroDouble(valor1) && Util.VerificaSeUmaStringEhUmNumeroDouble(valor2))
                        {
                            double v1 = double.Parse(valor1);
                            double v2 = double.Parse(valor2);

                            Console.Write("\nResultado: {0}\n", (Util.ApresentaUmDoubleComDuasCasasDecimais(calculadora.Multiplicar(v1, v2))));
                        }
                        else
                            Console.WriteLine("\nAlguma das entradas é inválida!!\n");

                        ResetarValores();

                        break;

                    case 4:

                        Console.WriteLine("\n===== DIVIDINDO DOIS VALORES =====");

                        PedeDoisValoresAoUsuario();

                        if (Util.VerificaSeUmaStringEhUmNumeroDouble(valor1) && Util.VerificaSeUmaStringEhUmNumeroDouble(valor2))
                        {
                            double v1 = double.Parse(valor1);
                            double v2 = double.Parse(valor2);

                            if (Util.VerificaSeUmValorDoubleEhZero(v1) != double.MinValue && Util.VerificaSeUmValorDoubleEhZero(v2) != double.MinValue)
                                Console.Write("\nResultado: {0}\n", (Util.ApresentaUmDoubleComDuasCasasDecimais(calculadora.Dividir(v1, v2))));
                            else
                                Console.WriteLine("\nNão podemos realizar divisões com o valor 0 (ZERO)!!\n");
                        }
                        else
                            Console.WriteLine("\nAlguma das entradas é inválida!!\n");

                        ResetarValores();

                        break;

                    case 5:
                        Console.WriteLine("\n===== APRESENTANDO O HISTÓRICO DE OPERAÇÕES =====");

                        calculadora.ApresentarHistoricoDeOperacoes();
                        break;
                }
            }
        }

        #region Métodos
        private static void PedeDoisValoresAoUsuario()
        {
            Console.Write("\nInforme o primeiro valor: ");

            valor1 = Console.ReadLine();

            Console.Write("\nInforme o segundo valor: ");

            valor2 = Console.ReadLine();
        }

        private static void ResetarValores()
        {
            valor1 = "";
            valor2 = "";
        }

        private static void SairDoSistema()
        {
            programaContinuaRepetindo = false;
        }

        #endregion
    }
}