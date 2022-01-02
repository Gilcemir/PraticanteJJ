using System;
using praticanteJJ;
namespace Main_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            PraticanteJJ ninja = new PraticanteJJ("Gilcemir Filho");
            ninja.Rank = "Preta";
            ninja.Weight = 78;
            ninja.Age = 30;


            ninja.print();
            ninja.Categoria();

        }

    }
}