using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 1. Escrever um algoritmo que leia 5 valores, um de cada vez, e conta quantos destes valores são negativos, escrevendo esta informação. (Utilize um array) [Feito em Aula]
 */
namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] numeros = new float[5];
            int count = 0;
            Console.WriteLine("Digite 5 valores para saber quais são negativos");

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = (float)Convert.ToDouble(Console.ReadLine());
                if (numeros[i] < 0) count++;
            }

            Console.WriteLine("Existem " + count + " numeros negativos, são eles:");
            /* Teste de respostas*/
            foreach (float num in numeros)
            {
                if (num < 0) Console.WriteLine(num);
            }
            
            Console.ReadKey();
        }
    }
}