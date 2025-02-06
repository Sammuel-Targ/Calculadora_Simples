using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Simples
{
    internal class Program
    {
        static void Main() 
        {
            int opcao;

            do
            {
                Console.Clear(); // Limpei a tela

                // Menu
                Console.WriteLine("Calculadora Simples");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine()); // leitura da opcao

                // limitando a escolha
                switch (opcao)
                {
                    case 1:
                        Somar();
                        break;
                    case 2:
                        Subtrair();
                        break;
                    case 3:
                        Multiplicar();
                        break;
                    case 4:
                        Dividir();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;

                }
            } while (opcao != 0); // nao fechar o programa ate que escolha a opcao 0
        }

        static void Somar()
        {
            int Valor1;
            int Valor2;

            int Resultado;

            Console.WriteLine("Digite o primeiro valor:");  // valor de entrada
            Valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");  // valor de entrada 2
            Valor2 = int.Parse(Console.ReadLine());

            Resultado = Valor1 + Valor2; // calculo

            Console.WriteLine("Resultado: " + Resultado);  // exibe resultado

            Console.ReadLine();  // computador lê o codigo
        }

        static void Subtrair() 
        {
            int Valor1;
            int Valor2;

            int Resultado;

            Console.WriteLine("Digite o primeiro valor:");
            Valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            Valor2 = int.Parse(Console.ReadLine());

            Resultado = Valor1 - Valor2;

            Console.WriteLine("Resultado: " + Resultado);

            Console.ReadLine();
        }

        static void Multiplicar() 
        {
            int Valor1;
            int Valor2;

            int Resultado;

            Console.WriteLine("Digite o primeiro valor:");
            Valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            Valor2 = int.Parse(Console.ReadLine());

            Resultado = Valor1 * Valor2;

            Console.WriteLine("Resultado: " + Resultado);

            Console.ReadLine();
        }

        static void Dividir() 
        {
            int Valor1;
            int Valor2;

            int Resultado;

            Console.WriteLine("Digite o primeiro valor:");
            Valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            Valor2 = int.Parse(Console.ReadLine());

            Resultado = Valor1 / Valor2;

            Console.WriteLine("Resultado: " + Resultado);

            Console.ReadLine();
        }

    }
}
