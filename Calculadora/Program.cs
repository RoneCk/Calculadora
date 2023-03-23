using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)

        {//Pergunta pro usuario qual operacao ele deseja fazer.
            Console.WriteLine("Qual operação deseja fazer:");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Multiplicação");
            Console.WriteLine("3- Divisão");
            Console.WriteLine("4- Subitração \n");

            //Usar 'Parse' para conversao para um numero inteiro.
            int operacao = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (operacao)
            {
                case 1:
                    {
                        resultado = Adicao(num1, num2);
                        break;
                    }
                case 2:
                    {
                        resultado = Multiplicacao(num1, num2);
                        break;
                    }
                case 3:
                    {
                        resultado = Divisao(num1, num2);
                        break;
                    }
                case 4:
                    {
                        resultado = Subtracao(num1, num2);
                        break;
                    }

                default:
                    Console.WriteLine("Numero invalido, digite outro numero.");
                    break;
            }
            Console.WriteLine("O resultado da operção com os números {0} e {1} é {2}", num1, num2, resultado);
        }

        public static int  Adicao(int numero1, int numero2)
        {
            int result = numero1 + numero2;
            return result;
        }

        public static int Multiplicacao(int numero1, int numero2)
        {
            int result = numero1 * numero2;
            return result;
        }

        public static int Divisao(int numero1, int numero2)
        {
            int result = numero1 / numero2;
            return result;
        }

        public static int Subtracao(int numero1, int numero2)
        {
            int result = numero1 - numero2;
            return result;
        }
    }
}