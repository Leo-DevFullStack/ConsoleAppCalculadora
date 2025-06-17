using System;
using System.ComponentModel.Design;
using System.Diagnostics;

namespace CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma operação matemática e digite dois valores!");
            Console.WriteLine("Opções: \n1º Somar \n2º Subtrair \n3º Dividir \n4º Multiplicar \n5º Resto da divisão (módulo) \n6° Sair da Calculadora Básica C#");
            Console.Write("Operação: ");
            short menuOpcao = short.Parse(Console.ReadLine());

            switch (menuOpcao)
            {
                case 1: Somar(); break;
                case 2: Subtrair(); break;
                case 3: Dividir(); break;
                case 4: Multiplicar(); break;
                case 5: Modulo(); break;
                case 6: Sair();  break;
                default: ValidarMenuOpcao(); break;
            }
        }
        static void Somar()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            float resultado = primeiroValor + segundoValor;

            Console.Clear();
            Console.WriteLine($"O resultado da soma de {primeiroValor} + {segundoValor} é: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Subtrair()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            float resultado = primeiroValor - segundoValor;

            Console.Clear();
            Console.WriteLine($"O resultado da subtração de {primeiroValor} - {segundoValor} é: {resultado}");
            Console.ReadKey();

            Menu();
        }
        static void Multiplicar()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            float resultado = primeiroValor * segundoValor;

            Console.Clear();
            Console.WriteLine($"O resultado da multipliacação de {primeiroValor} x {segundoValor} é: {resultado}");
            Console.ReadKey();

            Menu();
        }
        static void Dividir()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            float resultado = primeiroValor / segundoValor;

            Console.Clear();
            Console.WriteLine($"O resultado da divisão de {primeiroValor} / {segundoValor} é: {resultado}");
            Console.ReadKey();

            Menu();
        }
        static void Modulo()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            float resultado = primeiroValor % segundoValor;

            Console.Clear();
            Console.WriteLine($"O resultado do resto da divisão de {primeiroValor} por {segundoValor} é: {resultado}");
            Console.ReadKey();

            Menu();
        }
        static void Sair() 
        {
            Console.Clear();
            Console.WriteLine("Saindo da Aplicação! \nSee ya ^^");
            System.Environment.Exit(0);
        }
        static void ValidarMenuOpcao()
        {
            Console.WriteLine("\n *** ATENÇÃO ***");
            Console.WriteLine("\n- Ação Necessária: rodar o programa novamente!");
            Console.WriteLine("- Erro: digite um número inteiro, referente a operação matemática que deseja realizar!");
        }
    }
}