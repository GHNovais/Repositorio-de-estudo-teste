using System;

namespace Mini_Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char operacao;
            int num1, num2, soma;

            Console.WriteLine("Mini Calculadora");

            Console.WriteLine("\nInforme a operaçao: \n+ = Adição\n- = Subtração\n* = multiplicação\n/ = Divisão");
            operacao = Convert.ToChar(Console.ReadLine());

            if (operacao == '+')
            {
                Console.WriteLine("\nInforme o primeiro número:");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o segundo número:");
                num2 = Convert.ToInt32(Console.ReadLine());

                soma = num2 + num1;

                Console.WriteLine("\nResultado: "+soma);
                Console.ReadKey();
            }
            else if (operacao == '-')
            {
                Console.WriteLine("\nInforme o primeiro número:");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o segundo número:");
                num2 = Convert.ToInt32(Console.ReadLine());

                soma = num1 - num2;

                Console.WriteLine("Resultado: "+soma);
                Console.ReadKey();
            }
        }
    }
}