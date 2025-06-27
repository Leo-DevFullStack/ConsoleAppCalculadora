using System;
using System.Numerics;

namespace CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal();
        }

        /*
        Métodos dos Menus
        */
        static void MenuPrincipal()
        {
            Console.Clear();

            Console.WriteLine("----------> Menu Principal <----------\n");

            Console.WriteLine("Digite uma Opção!\n");

            Console.WriteLine("1 - Calculadora");
            Console.WriteLine("2 - Cronômetro");
            Console.WriteLine("0 - Sair do programa");

            Console.Write("\nOpção: ");

            if (!short.TryParse(Console.ReadLine(), out short menuPrincipalOpcao))
            {
                ValidarMenu();
                return;
            }

            switch (menuPrincipalOpcao)
            {
                case 1: MenuCalculadora(); break;
                case 2: MenuCronometro(); break;
                case 0: Sair(); break;
                default: ValidarMenu(); break;
            }
        }

        static void MenuCalculadora()
        {
            Console.Clear();

            Console.WriteLine("----------> Menu Calculadora <----------\n");

            Console.WriteLine("Digite uma Opção!\n");

            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisao");
            Console.WriteLine("5 - Resto da Divisao (Módulo)");
            Console.WriteLine("6 - Potenciação");
            Console.WriteLine("7 - Raiz Quadrada");
            Console.WriteLine("8 - Raiz Quadrada de Número Negativo");
            Console.WriteLine("9 - Equação de 1º Grau");
            Console.WriteLine("10 - Equação de 2º Grau / Fórmula de Bhaskara");
            Console.WriteLine("11 - Voltar ao Menu Principal");
            Console.WriteLine("0 - Sair do programa");

            Console.Write("\nOpção: ");

            if (!short.TryParse(Console.ReadLine(), out short menuCalculadoraOpcao))
            {
                ValidarMenu();
                return;
            }

            switch (menuCalculadoraOpcao)
            {
                case 1: Adicao(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: Modulo(); break;
                case 6: Potenciacao(); break;
                case 7: RaizQuadrada(); break;
                case 8: RaizQuadradaNegativa(); break;
                case 9: EquacaoPrimeiroGrau(); break;
                case 10: EquacaoSegundoGrau(); break;
                case 11: MenuPrincipal(); break;
                case 0: Sair(); break;
                default: ValidarMenu(); break;
            }
        }

        // Aqui modifico para incluir o menu cronometro completo e organizado
        static void MenuCronometro()
        {
            Console.Clear();

            Console.WriteLine("----------> Menu Cronômetro <----------\n");

            Console.WriteLine("Digite uma Opção!\n");

            Console.WriteLine("1 - Contagem Progressiva");
            Console.WriteLine("2 - Contagem Regressiva");
            Console.WriteLine("3 - Voltar ao Menu Principal");
            Console.WriteLine("0 - Sair do programa");

            Console.Write("\nOpção: ");

            if (!short.TryParse(Console.ReadLine(), out short menuCronometroOpcao))
            {
                ValidarMenu();
                return;
            }

            switch (menuCronometroOpcao)
            {
                case 1: IniciarCronometro(true); break;
                case 2: IniciarCronometro(false); break;
                case 3: MenuPrincipal(); break;
                case 4: Sair(); break;
                default: ValidarMenu(); break;
            }
        }

        /*
        Métodos da Calculadora
        */
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
            MenuCalculadora();
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

            MenuCalculadora();
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

            MenuCalculadora();
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

            MenuCalculadora();
        }
        static void Modulo()
        {
            Console.WriteLine("Digite o dividendo: ");
            float dividendo = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o divisor: ");
            float divisor = float.Parse(Console.ReadLine());

            float resto = dividendo % divisor;

            Console.Clear();
            Console.WriteLine($"O resultado do resto da divisão de {dividendo} por {divisor} é: {resto}");
            Console.ReadKey();

            MenuCalculadora();
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

            MenuCalculadora();
        }
        static void RaizQuadrada()
        {
            Console.WriteLine("Digite um número positivo para verificar sua raiz quadrada: ");
            
            float numero = float.Parse(Console.ReadLine());

            string resultado = numero < 0 ? "NaN \"Not-A-Number\" \nUse a operação para Raiz Quadrada de número negativo" : Convert.ToString(Math.Sqrt(numero));

            Console.Clear();
            Console.WriteLine($"A Raiz Quadrada de {numero} é: {resultado}");
            Console.ReadKey();

            MenuCalculadora();
        }
        static void RaizQuadradaNegativa()
        {
            Console.WriteLine("Digite um número negativo para verificar sua raiz quadrada: ");

            double numeroNegativo = double.Parse(Console.ReadLine());

            if (numeroNegativo < 0)
            {
                Complex raizComplexa = Complex.Sqrt(numeroNegativo);

                Console.Clear();
                Console.WriteLine($"A raiz quadrada de {numeroNegativo} é: {raizComplexa} número complexo com parte real e parte imaginária");
                Console.ReadKey();

                MenuCalculadora();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("O número digitado deve ser negativo para esse tipo de operação!");
                Console.ReadKey();

                RaizQuadradaNegativa();
            }
        }
        static void EquacaoPrimeiroGrau()
        {
            Console.Write("Digite o valor de a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de b: ");
            double b = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.Clear();
                    Console.WriteLine("A equação possui infinitas soluções.");
                    Console.ReadKey();

                    MenuCalculadora();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("A equação não possui solução.");
                    Console.ReadKey();

                    MenuCalculadora();
                }
            }
            else
            {
                double x = -b / a;

                Console.Clear();
                Console.WriteLine($"O valor de x é: {x}");
                Console.ReadKey();

                MenuCalculadora();
            }
        }
        static void EquacaoSegundoGrau()
        {
            Console.Write("Digite o valor de a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de b: ");
            double b = double.Parse(Console.ReadLine());     
            Console.Write("Digite o valor de b: ");
            double c = double.Parse(Console.ReadLine());

            double delta = (b * b) - 4 * a * c;

            if (a == 0)
            {
                Console.Clear();
                Console.WriteLine("O coeficiente \"a\" (que multiplica o termo x²) não pode ser zero. Se \"a\" fosse zero, a equação se reduziria a uma equação do primeiro grau (bx + c = 0)");
                Console.ReadKey();

                MenuCalculadora();
            }
            else if (delta < 0)
            {
                Console.Clear();
                Console.WriteLine("Não existem raízes reais.");
                Console.ReadKey();

                MenuCalculadora();
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);

                Console.Clear();
                Console.WriteLine($"Raiz única: x = {x}");
                Console.ReadKey();

                MenuCalculadora();
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.Clear();
                Console.WriteLine($"Raízes: x1 = {x1}, x2 = {x2}");
                Console.ReadKey();

                MenuCalculadora();
            }
        }

        /*
        Métodos do Cronômetro
        */


        /*
        Métodos Gerais
        */
        static void ValidarMenu()
        {
            Console.Clear();
            Console.WriteLine("----------> ATENÇÃO <----------\n\n");
            Console.WriteLine("Ação Necessária: rodar o programa novamente!\n");
            Console.WriteLine("Erro: digite um número inteiro, referente a opção que deseja realizar!");
            Console.WriteLine("\n\nErro - Finalizando o Programa");

            Thread.Sleep(7000);
            
            Sair();
        }
        static void Sair() 
        {
            Console.WriteLine("\n----------> SAINDO DA APLICAÇÃO <----------");

            Thread.Sleep(2000);

            System.Environment.Exit(0);
        }
    }
}