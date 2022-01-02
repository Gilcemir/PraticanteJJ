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

        private string CategoriaPeso() 
        {
            if (this.Sex == "Masc")
            {
                switch (this.Weight)
                {
                    case < 57.50:
                        return "Galo";
                    case < 64:
                        return "Pluma";
                    case < 70:
                        return "Pena";
                    case < 76:
                        return "Leve";
                    case < 82.3:
                        return "Médio";
                    case < 88.3:
                        return "Meio-Pesado";
                    case < 94.3:
                        return "Pesado";
                    case < 100.5:
                        return "Super Pesado";
                    default:
                        return "Pesadíssimo";
                }
            }
            else
            {
                switch (this.Weight)
                {
                    case < 53.5:
                        return "Pluma";
                    case < 58.5:
                        return "Pena";
                    case < 64:
                        return "Leve";
                    case < 69:
                        return "Médio";
                    case < 74:
                        return "Meio-Pesado";
                    default:
                        return "Pesado";
                }
            }
        }


        private string CategoriaIdade() 
        {
            switch (this.Age)
            {
                case < 18:
                    return "Crianças - Not avaible yet";
                case < 30:
                    return "Adulto";
                case < 35:
                    return "Master 1";
                case < 40:
                    return "Master 2";
                case < 45:
                    return "Master 3";
                case < 50:
                    return "Master 4";
                case < 55:
                    return "Master 5";
                default :
                    return "Master 6";


            }
        }

        public void Categoria()
        {
            string sexo = (this.Sex == "Masc") ?"Masculino":"Feminino";
            Console.WriteLine("{0} | {1} | {2} | {3} ", CategoriaIdade(), sexo, Rank, CategoriaPeso());
        }
    }
}

