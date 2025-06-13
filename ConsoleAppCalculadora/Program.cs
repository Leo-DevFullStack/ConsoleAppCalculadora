using System;

namespace CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuOpcao = 0;

            Console.WriteLine("Escolha uma operação matemática e digite dois valores");

            Console.WriteLine("Opções: \n 1º Somar \n 2º Subtrair \n 3º Dividir \n 4º Multiplicar \n 5º Resto da divisão (módulo) \n 6° Sair da Calculadora Básica C#");

        }
        static void Somar()
        {
            Console.WriteLine ("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine ());
            
            Console.WriteLine("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            float resultado = primeiroValor + segundoValor;

            Console.WriteLine($"O resultado da operação é {resultado}");
        }
        static void Subtrair()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            float resultado = primeiroValor - segundoValor;

            Console.WriteLine($"O resultado da operação é {resultado}");
        }
        static void Multiplicar()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            float resultado = primeiroValor * segundoValor;

            Console.WriteLine($"O resultado da operação é {resultado}");
        }
        static void Dividir()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            float resultado = primeiroValor / segundoValor;

            Console.WriteLine($"O resultado da operação é {resultado}");
        }
        static void Modulo()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            float primeiroValor = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float segundoValor = float.Parse(Console.ReadLine());

            float resultado = primeiroValor % segundoValor;

            Console.WriteLine($"O resultado da operação é {resultado}");
        }
    }
}