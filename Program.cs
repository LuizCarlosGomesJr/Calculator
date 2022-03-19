using System;

namespace Calculator
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

            Console.WriteLine("-- Calculadora --");
            Console.WriteLine("");
            Console.WriteLine("---- Menu de opções ----");
            Console.WriteLine("1 - Somar:");
            Console.WriteLine("2 - Subtrair:");
            Console.WriteLine("3 - Multiplicar:");
            Console.WriteLine("4 - Divivir:");
            Console.WriteLine("5 - Sair:");

            Console.WriteLine("");
            Console.WriteLine("Digite a opção desejada:");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtrair(); break;
                case 3: Multiplicar(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

            Console.ReadKey();

        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("----- Somar -----");
            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float res = v1 + v2;

            Console.WriteLine($"A soma dos valores é {res}");
            Console.ReadKey();
            Menu();
        }

        static void Subtrair()
        {
            Console.Clear();
            Console.WriteLine("--- Subtrair ---");

            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float res = v1 - v2;

            Console.WriteLine($"A subtração dos valores é {res}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicar()
        {
            Console.Clear();
            Console.WriteLine("-- Multiplicar --");

            Console.WriteLine("Digite o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float res = v1 * v2;

            Console.WriteLine($"A multiplicação dos valores é {res}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("--- Divisão ---");

            Console.WriteLine("Digite o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float res = v1 / v2;

            Console.WriteLine($"A divisão dos valores é {res}");
            Console.ReadKey();
            Menu();
        }
    }
}
