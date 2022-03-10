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
            Convert.ToChar(Console.ReadLine());

        }
    }
}