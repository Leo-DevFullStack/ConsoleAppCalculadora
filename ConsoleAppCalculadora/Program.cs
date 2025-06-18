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
            Console.WriteLine("0 - Sair da Calculadora");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisao");
            Console.WriteLine("5 - Resto da Divisao (Módulo)");
            Console.WriteLine("6 - Potenciação");
            Console.WriteLine("7 - Raiz Quadrada");
            Console.Write("Operação: ");
            short menuOpcao = short.Parse(Console.ReadLine());

            switch (menuOpcao)
            {
                case 1: Adicao(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: Modulo(); break;
                case 6: Potenciacao(); break;
                case 7: RaizQuadrada(); break;
                case 0: Sair();  break;
                default: ValidarMenuOpcao(); break;
            }
        }
        static void ValidarMenuOpcao()
        {
            Console.WriteLine("\n *** ATENÇÃO ***");
            Console.WriteLine("\n- Ação Necessária: rodar o programa novamente!");
            Console.WriteLine("- Erro: digite um número inteiro, referente a operação matemática que deseja realizar!");
        }
        static void Adicao()
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
        static void Subtracao()
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
        static void Multiplicacao()
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
        static void Divisao()
        {
            Console.WriteLine("Digite o dividendo: ");
            float dividendo = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o divisor: ");
            float divisor = float.Parse(Console.ReadLine());

            float quociente = dividendo / divisor;

            Console.Clear();
            Console.WriteLine($"O quociente da divisão de {dividendo} / {divisor} é: {quociente}");
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
        static void Potenciacao()
        {
            Console.WriteLine("Digite o valor base: ");
            double valorBase = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            double expoente = double.Parse(Console.ReadLine());

            double resultado = Math.Pow(valorBase, expoente);

            Console.Clear();
            Console.WriteLine($"O resultado da exponenciação de {valorBase} ^ {expoente} é: {resultado}");
            Console.ReadKey();

            Menu();
        }
        static void RaizQuadrada()
        {
            Console.WriteLine("Digite um número positivo para verificar sua raiz quadrada: ");
            
            float numero = float.Parse(Console.ReadLine());

            string resultado = numero < 0 ? "NaN \"Not-A-Number\" - Não existe raiz quadrada de número negativo" : Convert.ToString(Math.Sqrt(numero));

            Console.Clear();
            Console.WriteLine($"A Raiz Quadrada de {numero} é: {resultado}");
            Console.ReadKey();

            Menu();
        }
        static void Sair() 
        {
            Console.Clear();
            Console.WriteLine("Saindo da Aplicação! \nSee ya ^^");
            System.Environment.Exit(0);
        }
    }
}