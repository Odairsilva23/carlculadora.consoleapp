using System;

namespace Calculadora.ConsoleApp
{
    class Program
    {
        #region Requisito 01 [OK]
        //Nossa calculadora deve ter a possibilidade de somar dois números
        #endregion

        #region Requisito 02 [OK]
        //Nossa calculadora deve ter a possibilidade fazer várias operações de soma
        #endregion

        #region Requisito 03 [OK]
        //Nossa calculadora deve ter a possibilidade fazer várias operações de soma e de subtração
        #endregion

        #region Requisito 04 [OK]
        //Nossa calculadora deve ter a possibilidade fazer as quatro operações básicas da matemática
        #endregion

        #region Requisito 05 [OK]
        //Nossa calculadora deve validar a opções do menu [OK]
        #endregion

        #region BUG 01 [OK]
        //Nossa calculadora deve realizar as operações com "0"
        #endregion

        #region Requisito 06
        /** Nossa calculadora deve permitir visualizar as operações já realizadas
         *  Critérios:
         *      1 - A descrição da operação realizada deve aparecer assim, exemplo:
         *          2 + 2 = 4
         *          10 - 5 = 5
         *      2 - Deve mostrar msg de erro caso nao tenha nhuma operação Realiza :
         *      Nenhuma Operação Realizada.
         */
        #endregion

        static void Main(string[] args, int primeiroNumero, int segundoNumero)
        {
            string[] operacoesRealizadas = new string[100];
            string opcao = "";
            int contador = 0;

            while (true)
            {
                Menu();

                opcao = Console.ReadLine();


                if (opcaodeoperacoes(opcao))
                {
                    string mensagemErro = "Opção inválida! Tente novamente";,

                    mensagemdeerro(mensagemErro);

                    continue;
                }

                if (opcaodevisualizao(opcao))

                {
                    Console.WriteLine();

                    if (contador == 0)

                        Console.WriteLine("nenhuma operação foi realizada");


                    else

                        opcoadevisualizacaodeOperacoes(operacoesRealizadas);
                    Console.ReadLine();
                    Console.Clear();

                    continue;

                }
                if (opcaoasair(opcao))

                    break;


                double primeiroNumero, segundoNumero;

                primeiroNumero = ObterNumero("Primeiro Numero");

                do
                {
                    segundoNumero = ObterNumero("segundo Numero");

                    if (segundonumeroInvalido(opcao, segundoNumero))

                        mensagemdeerro("Segundo número inválido! Tente novamente");


                } while (segundonumeroInvalido(opcao, segundoNumero));

                double resultado = CalcularResultado(opcao, primeiroNumero, segundoNumero);

                string simboloOperacao = ObterSimbolo(opcao);


                string operacaoRealizada = $"{primeiroNumero} {simboloOperacao} {segundoNumero} = {resultado}";


                operacoesRealizadas[contador] = operacaoRealizada;
                contador++;



                Console.WriteLine(resultado);

                Console.WriteLine();

                Console.WriteLine(operacaoRealizada);

                Console.ReadLine();

                Console.Clear();

            }
        }

        private static string ObterSimbolo()
        {
            throw new NotImplementedException();
        }

        private static string ObterSimbolo(string opcao)
        {
            string simboloOperacao = "";
            switch (opcao)
            {
                case "1":
                    simboloOperacao = "+"; break;

                case "2":
                    simboloOperacao = "-"; break;

                case "3":
                    simboloOperacao = "*"; break;

                case "4":
                    simboloOperacao = "/"; break;

                default:
                    break;
            }
            return simboloOperacao;
        }
        private static double CalcularResultado(string opcao, double primeiroNumero, double segundoNumero)
        {
            double resultado = 0;
            switch (opcao)
            {
                case "1":
                    resultado = primeiroNumero + segundoNumero; break;

                case "2":
                    resultado = primeiroNumero - segundoNumero; break;

                case "3":
                    resultado = primeiroNumero * segundoNumero; break;

                case "4":
                    resultado = primeiroNumero / segundoNumero; break;

                default:
                    break;
            }
            return resultado;
        }


        private static bool segundonumeroInvalido(string opcao, double segundoNumero)
        {
            return opcao == "4" && segundoNumero == 0;
        }

        private static double ObterNumero(string ordem)
        {
            Console.WriteLine($"Digite {ordem} do Numero: ");

            double numero = Convert.ToDouble(Console.ReadLine{ } );

            return numero;
        }

        private static bool opcaoasair(string opcao)
        {
            return opcao.Equals("s", StringComparison.OrdinalIgnoreCase);
        }

        private static void opcoadevisualizacaodeOperacoes(string[] operacoesRealizadas)
        {
            for (int i = 0; i < operacoesRealizadas.Length; i++)
                Console.WriteLine();
            {

                if (operacoesRealizadas[i] != null)
                    Console.WriteLine(operacoesRealizadas[i]);
            }
        }

        private static bool opcaodevisualizao(string opcao)
        {
            return opcao == "5";
        }

        private static void mensagemdeerro(string mensagemErro)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(mensagemErro);

            Console.ResetColor();

            Console.ReadLine();

            Console.Clear();
        }

        private static bool opcaodeoperacoes(string opcao)
        {
            return opcao != "1" && opcao != "2" && opcao != "3"
                                && opcao != "4" && opcao != "5"
                                && opcao != "S" && opcao != "s";
        }

        private static void Menu()
        {
            Console.WriteLine("Calculadora Tabajara 1.7.1");

            Console.WriteLine();

            Console.WriteLine("Digite 1 para somar");

            Console.WriteLine("Digite 2 para subtrair");

            Console.WriteLine("Digite 3 para multiplicação");

            Console.WriteLine("Digite 4 para divisão");

            Console.WriteLine("Digite 5 para visualizar as operações realizadas");

            Console.WriteLine("Digite S para sair");
        }
    }
}

