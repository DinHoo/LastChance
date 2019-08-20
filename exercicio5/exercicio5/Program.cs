using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    public class Personagem
    {
        /////////////////////////////
        /// Sexo
        private string sexo;

        public void setSexo(string sexo)
        {
            this.sexo = sexo;
        }
        public string getSexo()
        {
            return sexo;
        }

        /////////////////////////////
        /// Cor Dos Olhos
        private string corDosOlhos;
        public void setCordosolhos(string corDosolhos)
        {
            this.corDosOlhos = corDosolhos;
        }
        public string getCordosolhos()
        {
            return corDosOlhos;
        }

        /////////////////////////////
        /// Cor Do Cabelo
        private string corDoCabelo;
        public void setCordocabelo(string corDocabelo)
        {
            this.corDoCabelo = corDocabelo;
        }
        public string getCordocabelo()
        {
            return corDoCabelo;
        }

        /////////////////////////////
        /// Level
        private int level;

        public void setLevel(int level)
        {
            this.level = level;
        }
        public int getLevel()
        {
            return level;
        }

        /////////////////////////////

        public Personagem(int level, string corDosolhos, string sexo, string corDocabelo)
        {
            this.level = level;
            this.corDosOlhos = corDosolhos;
            this.sexo = sexo;
            this.corDoCabelo = corDocabelo;
        }
        public Personagem()
        {

        }

    }

    class Program
    {
        static void Main()
        {
            bool condicaoDeParada = true;
            int index = 1;
            List<Personagem> personagensLista = new List<Personagem>();

            while (condicaoDeParada)
            {
                Personagem p = new Personagem();
                Console.WriteLine(" Personagem número: " + index);
                Console.WriteLine("Level do personagem: ");
                p.setLevel(Convert.ToInt32(Console.ReadLine()));
                if (p.getLevel() == -1)
                {
                    condicaoDeParada = false;
                    break;
                }

                Console.WriteLine("Sexo do personagem: ");
                p.setSexo(Console.ReadLine().ToLower());

                Console.WriteLine("Cor dos olhos do personagem: ");
                p.setCordosolhos(Console.ReadLine().ToLower());

                Console.WriteLine("Cor do cabelo do personagem: ");
                p.setCordocabelo(Console.ReadLine().ToLower());

                personagensLista.Add(p);
                index++;

            }
            List<int> todosLevels = personagensLista.Select(x => x.getLevel()).ToList();
            // adiciona todos os levels  numa lista de inteiros
            todosLevels.Sort();
            // ordena ela

            if (todosLevels.Any()) // testa pra ver se a lista não está vazia
            {
                Console.WriteLine("Maior level é: " + todosLevels.Last());

                List<Personagem> feminaze = personagensLista.FindAll(x => ((x.getLevel() >= 18 && x.getLevel() <= 35) && (x.getCordosolhos() == "verdes") && (x.getCordocabelo() == "louros")));
                //Console.WriteLine("feminazes é: " + feminaze.Count);

                List<Personagem> antiNazi = personagensLista.FindAll(x => ((x.getCordosolhos() != "azuis") && (x.getCordocabelo() != "louros")));
                //Console.WriteLine("antinazes é: " + antiNazi.Count);
                //Console.WriteLine("total de personagens: " + personagensLista.Count);


                Console.WriteLine("Percentual de personagens que não possuem olhos azuis nem cabelos louros é: " + (float)(antiNazi.Count) / (float)(personagensLista.Count) * 100);
            }
            Console.ReadKey();

        }
    }
}