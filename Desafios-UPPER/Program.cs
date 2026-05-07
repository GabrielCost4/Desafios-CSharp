using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_UPPER
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Exercício 1

            int soma = 0;
            var contador = 10;

            for (int i = 1; i <= contador; i++)
            {
                soma = soma + i;
            }

            Console.WriteLine("----------- EXERCÍCIO 1 -----------");
            Console.WriteLine($"A soma dos números de 1 a 10 é: {soma}");
            Console.WriteLine();


            //Exercício 2

            Console.WriteLine("----------- EXERCÍCIO 2 -----------");

            Console.Write("Digite seu peso em quilos: ");
            double pesoAtual = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite sua altura em metros: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            var calculoIMC = pesoAtual / (altura * altura);

            if (calculoIMC < 18.5)
            {
                Console.WriteLine($"Seu IMC é {calculoIMC:F2} e você está abaixo do peso ideal!");
            }
            else if (calculoIMC <= 24.9)
            {
                Console.WriteLine($"Seu IMC é {calculoIMC:F2} e você está no peso ideal!");
            }
            else if (calculoIMC <= 29.9)
            {
                Console.WriteLine($"Seu IMC é {calculoIMC:F2} e você está com sobrepeso!");
            }
            else if (calculoIMC <= 34.9)
            {
                Console.WriteLine($"Seu IMC é {calculoIMC:F2} e você está com obesidade Grau I!");
            }
            else if (calculoIMC <= 39.9)
            {
                Console.WriteLine($"Seu IMC é {calculoIMC:F2} e você está com obesidade Grau II!");
            }
            else
            {
                Console.WriteLine($"Seu IMC é {calculoIMC:F2} e você está com obesidade Grau III!");
            }

            Console.WriteLine();


            //Exercício 3
            Console.WriteLine("----------- EXERCÍCIO 3 -----------");

            Console.Write("Digite um número: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite outro número: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a operação que deseja realizar (+, -, *, /): ");
            string operacao = Console.ReadLine();

            switch (operacao)
            {
                case "+":
                    Console.WriteLine($"A soma entre os números é: {n1 + n2}");
                    break;

                case "-":
                    Console.WriteLine($"A subtração entre os números é: {n1 - n2}");
                    break;

                case "*":
                    Console.WriteLine($"A multiplicação entre os números é: {n1 * n2}");
                    break;

                case "/":
                    if (n2 != 0)
                        Console.WriteLine($"A divisão entre os números é: {n1 / n2}");
                    else
                        Console.WriteLine("Erro: divisão por zero!");
                    break;

                default:
                    Console.WriteLine("Operação inválida!");
                    break;
            }

        }
    }
}
