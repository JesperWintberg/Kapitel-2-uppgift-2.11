using System;
namespace Uppgift_2_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Elin och Alam?");
            Console.WriteLine("Hur långt hoppade Elin i meter?"); string Elin = Console.ReadLine();
            Console.WriteLine("Hur långt hoppade Alma i meter?"); string Alma = Console.ReadLine();

            float Elin_längd_tal = float.Parse(Elin);
            float Alma_längd_tal = float.Parse(Alma);

            float Skilland = Elin_längd_tal - Alma_längd_tal; 

            Console.WriteLine("Elin hoppade" + Skilland + "Längre en Alma ");
        }
    }


}

