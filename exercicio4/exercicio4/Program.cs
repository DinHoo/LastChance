using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Em um jogo, um grupo de  inimigos é gerado aleatoriamente. Para refinar essa geração, a empresa do jogo deseja criar um programa para coletar informações sobre eles . 
 * Foram coletados os dados de HP do inimigo, sexo (M/F), força e defesa. Faça um algoritmo que informe: a) a média de HP do grupo; b) maior e menor HP do grupo; 
 * c) quantidade de inimigos mulheres com Força até 50.  c) quantidade de inimigos homens com Força e Defesa maiores que 35. Encerre a entrada de dados quando for digitada um HP negativo.
 * (Crie uma classe para os inimigos e utilize listas ou arrays)
 */

namespace Exercicio4
{
    class Inimigo
    {
        public int _hp;
        public char _sexo;
        public int _for;
        public int _def;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Inimigo> listaDeInimigos = new List<Inimigo>();

            bool condicional = true;
            int index = 1;

            do
            {
                Console.WriteLine("inimigo numero " + index);
                Inimigo _i = new Inimigo();
                Console.WriteLine("Informe o HP");
                _i._hp = Convert.ToInt32(Console.ReadLine());
                if (_i._hp < 0)
                    break;
                Console.WriteLine("Informe o sexo");
                _i._sexo = Console.ReadLine()[0];
                _i._sexo = _i._sexo.ToString().ToLower()[0];
                Console.WriteLine("Informe a Força");
                _i._for = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe a Defesa");
                _i._def = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------");
                listaDeInimigos.Add(_i);
                index++;
            } while (condicional);

            List<int> listaHp = listaDeInimigos.Select(x => x._hp).ToList();
            listaHp.Sort();

            int mulher50 = listaDeInimigos.FindAll(x => x._sexo == 'f' && x._for <= 50).Count;
            int homem35 = listaDeInimigos.FindAll(x => x._sexo == 'm' && x._for > 35 && x._def > 35).Count;


            Console.WriteLine("-----------");
            Console.WriteLine("media hp " + listaHp.Average());
            Console.WriteLine("menor hp " + listaHp.First());
            Console.WriteLine("maior hp " + listaHp.Last());
            Console.WriteLine("quantidade de inimigos mulheres com Força até 50: " + mulher50);
            Console.WriteLine("quantidade de inimigos homens com Força e Defesa maiores que 35: " + homem35);
            Console.ReadKey();
        }

    }
}
