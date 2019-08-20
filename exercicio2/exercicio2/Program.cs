using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Faça um algoritmo que leia uma quantidade não determinada de números positivos. Calcule a quantidade de números pares e ímpares,
 * a média de valores pares e a média geral dos números lidos. O número que encerrará a leitura será zero. (Utilize uma função/Método)
 */
namespace Exercicio3
{
    class Program
    {
        public static void printLista<T>(List<T> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
        }

        static public float MediaDosValores(List<float> valores)
        {
            float media = 0;
            for (int i = 0; i < valores.Count; i++)
            {
                media += valores[i];
            }

            return media / valores.Count;
        }

        static void Main(string[] args)
        {
            List<float> listaNumeros = new List<float>();
            Console.WriteLine("Digite quantos numeros positivos quiser, digite 0 quando acabar de digitar o conjunto");
            Console.WriteLine("Será mostrado dados sobre esse conjunto");

            bool condicao = true;
            float val;

            while (condicao)
            {
                val = (float)Convert.ToDouble(Console.ReadLine());

                if (val > 0)
                {
                    listaNumeros.Add(val);
                }
                else if (val < 0)
                {
                    Console.WriteLine("Inválido, numero negativo");
                }
                else if (val == 0)
                    condicao = false;
            }

            List<float> listaPares = listaNumeros.FindAll(x => x % 2 == 0);
            int qtdImpares = listaNumeros.FindAll(x => x % 2 != 0).Count;

            Console.WriteLine("-----------");
            /*
            Program.printLista<float>(listaNumeros);
            Console.WriteLine("-----------");
            Program.printLista<float>(listaPares);
            Console.WriteLine("-----------");
            Console.WriteLine(qtdImpares);
            */
            Console.WriteLine("Quantidade de Pares: " + listaPares.Count);
            Console.WriteLine("Quantidade de Impares: " + qtdImpares);
            Console.WriteLine("Media dos valores Pares: " + MediaDosValores(listaPares));
            Console.WriteLine("Media geral: " + MediaDosValores(listaNumeros));


            Console.ReadKey();
        }
    }
}
