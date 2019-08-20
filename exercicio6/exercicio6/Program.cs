using System;

namespace exercicio6
{
    public class Calculadora
    {
        static public double soma(double numA, double numB)
        {
            return numA + numB;
        }

        static public double subtracao(double numA, double numB)
        {
            return numA - numB;
        }

        static public double multiplicacao(double numA, double numB)
        {
            return numA * numB;
        }

        static public double divisao(double numA, double numB)
        {
            if (numB == 0)
            {
                Console.WriteLine("Divisão por zero");
            }

            return numA / numB;
        }
    }

    public class CalculadoraCientifica : Calculadora
    {
        public static double raizquadrada(double numA)
        {
            return Math.Sqrt(numA);
        }
    }

    internal class Program
    {
        private static void Main()
        {
            double numA;
            double numB;
            int escolha;
            bool calculadoraCientifica = false;

            while (true)
            {
                Console.WriteLine("Escolha: ");
                Console.WriteLine("1 - Calculadora Normal");
                Console.WriteLine("2 - Calculadora Cientifica");

                escolha = Convert.ToInt32(Console.ReadLine());

                if (escolha != 1 && escolha != 2) break;

                if (escolha == 1 || escolha == 2)
                {
                    Console.WriteLine("Operações: ");
                    Console.WriteLine("1 - Soma");
                    Console.WriteLine("2 - Subtração");
                    Console.WriteLine("3 - Multiplicação");
                    Console.WriteLine("4 - Divisão");

                    if (escolha == 2)
                    {
                        calculadoraCientifica = true;
                        Console.WriteLine("5 - Raiz Quadrada");
                    }
                }

                escolha = Convert.ToInt32(Console.ReadLine());

                if (escolha == 5 && calculadoraCientifica)
                {
                    Console.WriteLine("Informe o primeiro numeroA: ");
                    numA = Convert.ToDouble(Console.ReadLine());
                    numB = 1;
                }
                else if (escolha != 5)
                {
                    Console.WriteLine("Informe o primeiro numeroA: ");
                    numA = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Informe o segundo numeroB: ");
                    numB = Convert.ToDouble(Console.ReadLine());
                }
                else
                    break;

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("resposta: " + Calculadora.soma(numA, numB));
                        break;

                    case 2:
                        Console.WriteLine("resposta: " + Calculadora.subtracao(numA, numB));
                        break;

                    case 3:
                        Console.WriteLine("resposta: " + Calculadora.multiplicacao(numA, numB));
                        break;

                    case 4:
                        Console.WriteLine("resposta: " + Calculadora.divisao(numA, numB));
                        break;

                    case 5:
                        if (calculadoraCientifica)
                        {
                            Console.WriteLine("resposta: " + CalculadoraCientifica.raizquadrada(numA));
                        }
                        break;
                }

                Console.ReadKey();
            }
        }
    }
}