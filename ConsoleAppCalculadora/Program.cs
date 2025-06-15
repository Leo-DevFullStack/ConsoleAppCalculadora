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
                case 6:
                    {
                        Console.Clear();
                        Console.WriteLine("Saindo da Aplicação! \nSee ya ^^");
                        System.Environment.Exit(0);
                    }
                    break;
                default: Menu(); break;
            }
        }
        static void Somar()
        {
            Console.WriteLine ("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine ());
            Console.WriteLine("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());
            
            float resultado = primeiroValor + segundoValor;
            
            Console.Clear();
            Console.WriteLine($"O resultado da operação é {resultado}");
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
            Console.WriteLine($"O resultado da operação é {resultado}");
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
            Console.WriteLine($"O resultado da operação é {resultado}");
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
            Console.WriteLine($"O resultado da operação é {resultado}");
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
            Console.WriteLine($"O resultado da operação é {resultado}");
            Console.ReadKey();

            Menu();
        }
    }
}