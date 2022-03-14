using System;

namespace CalculadoraPOO.ConsoleApp
{
    public class MenuPrincipal
    {
        private string opcaoInputadaPeloUsuario = "";
        private int inicioMenu = 0, fimMenu = 4;

        public int ApresentarMenuEhRetornaAhOpcaoSelecionada()
        {
            Console.WriteLine("\n==== Menu Principal ====");
            Console.WriteLine(" * Digite 1 para somar;");
            Console.WriteLine(" * Digite 2 para subtrair;");
            Console.WriteLine(" * Digite 3 para multiplicar;");
            Console.WriteLine(" * Digite 4 para dividir;");
            Console.WriteLine(" * Digite 0 para sair;");
            Console.Write("Sua escolha: ");

            opcaoInputadaPeloUsuario = Console.ReadLine();

            int retorno = int.MinValue;

            if (Util.VerificaSeUmaStringEhUmNumeroInteiro(opcaoInputadaPeloUsuario) == true)
            {
                int numero = Util.VerificaSeUmValorPertenceAhUmIntervaloDeInteiros(int.Parse(opcaoInputadaPeloUsuario), inicioMenu, fimMenu);

                if (numero != int.MinValue)
                {
                    retorno = numero;

                    return retorno;
                }
            }
            else
            {
                retorno = int.MaxValue;
            }

            opcaoInputadaPeloUsuario = "";

            return retorno;
        }
    }
}
