
namespace Calculadora.ConsoleApp
{


    internal class Program
    {
        static void Main(string[] args)
        {

            do

            {

                Console.Clear();

                Console.WriteLine("Calculadora Top 2023");

                Console.WriteLine("Digite 1 para somar");
                Console.WriteLine("Digite 2 para subtrair");
                Console.WriteLine("Digite 3 para multiplicar");
                Console.WriteLine("Digite 4  para dividir");
                Console.WriteLine("Digite 5  para gerar tabuada");
                Console.WriteLine("Digite S para sair");

                string operacao = Console.ReadLine();

                if (operacao == "S" || operacao == "s")
                {
                    break;
                }

                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "5")
                {
                    Console.WriteLine("Operação inválida, tente novamente...");
                    Console.ReadLine();
                    continue;

                }
                if (operacao == "5")
                {
                    Console.Write("Digite o numero para gerar a tabuada");

                    int tabuada = Convert.ToInt32 (Console.ReadLine());
                    int numero = 1;

                    while (numero <= 10)
                    {
                        int resultadoMultiplicacao = tabuada * numero;

                        Console.WriteLine(tabuada + " x" + numero + " = " + resultadoMultiplicacao);
                        
                         numero = numero + 1;
                    }
                }

                //
                Console.WriteLine();
                //

                Console.Write("Digite o primeiro número:");

                decimal numero1 = Convert.ToDecimal(Console.ReadLine());

                //

                Console.Write("Digite o segundo número:");

                decimal numero2 = Convert.ToDecimal(Console.ReadLine());

                //

                decimal resultado = 0;

                bool adicao = operacao == "1";
                bool subtracao = operacao == "2";
                bool multiplicacao = operacao == "3";
                bool divisao = operacao == "4";

                if (operacao == "1")
                {
                    resultado = numero1 + numero2;

                }


                else if (operacao == "2")
                {
                    resultado = numero1 - numero2;

                }

                else if (operacao == "3")
                {
                    resultado = numero1 * numero2;

                }


                else if (operacao == "4")
                {
                    while (numero2 == 0)
                    {
                        Console.WriteLine("Segundo número não pode ser ZERO, tente novamente");

                        Console.Write("Digite o segundo número:");

                        numero2 = Convert.ToDecimal(Console.ReadLine());


                    }

                    resultado = numero1 / numero2;
                }

                decimal formatado = Math.Round(resultado, 2);

                Console.WriteLine("O resultado da operação é:" + formatado);

                Console.ReadLine();

            } while (true);



        }
    }
}