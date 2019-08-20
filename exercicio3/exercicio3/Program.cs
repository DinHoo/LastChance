using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Uma empresa de um MMORPG quer fazer um programa para descobrir alguns dados sobre os personagens dos jogadores. A empresa deseja saber: 
 * a) média de Gold dos personagens; b) média do número de montarias; c) maior valor de Gold; 
 * d) percentual de personagens com Gold até 100. O programa deverá ficar lendo dados de personagens até que haja a entrada de uma quantidade de gold negativa. 
 * (Use o comando WHILE) [Feito em Aula]
 */

namespace Exercicio3
{
    class Jogador
    {
        public int gold;
        public int montaria;
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<Jogador> listaDeJog = new List<Jogador>();

            int gold = -1;

            do
            {
                Jogador j = new Jogador();
                Console.WriteLine("Informe seu Gold");
                gold = Convert.ToInt32(Console.ReadLine());
                if (gold < 0)
                    break;
                j.gold = gold;

                Console.WriteLine("Informe quantidade de montarias");
                j.montaria = Convert.ToInt32(Console.ReadLine());
                listaDeJog.Add(j);
            } while (!(gold < 0));

            List<int> listaGold = listaDeJog.Select(x => x.gold).ToList();

            double mediaGold = listaGold.Average();
            double mediaMontaria = listaDeJog.Select(x => x.montaria).ToList().Average();

            listaGold.Sort();



            Console.WriteLine("-----------");
            Console.WriteLine("Média de Gold: " + mediaGold);
            Console.WriteLine("Média de Montarias: " + mediaMontaria);
            Console.WriteLine("Maior Gold: " + listaGold.Last());
            Console.WriteLine("% de Personagens com até 100G: " + ((double)listaDeJog.FindAll(x => x.gold <= 100).Count / (double)listaDeJog.Count) * 100 + "%");

            Console.ReadKey();
        }
    }
}
