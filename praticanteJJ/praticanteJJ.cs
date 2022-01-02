using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praticanteJJ
{
    public class PraticanteJJ
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Sex { get; set; }
        public string Rank { get; set; }

        public PraticanteJJ(string name)
        {
            Name = name;
            Rank = "Branca";
            Weight = 50;
            Sex = "Masc";
            Age = 18;
        }

        public void print()
        {
            Console.WriteLine("Nome : {0}", this.Name);
            Console.WriteLine("Idade : {0}", this.Age);
            Console.WriteLine("Peso : {0}", this.Weight);
            Console.WriteLine("Sexo : {0}", this.Sex);
            Console.WriteLine("Faixa : {0}", this.Rank);
        }
    }
}

