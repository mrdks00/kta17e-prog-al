using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timestamps
{
    //Proramm küsib kasutaja käest kolme sisendit: 
    //a) minimaalne aasta arv, 
    //b) maksimaalne aasta arv, 
    //c) suvaliselt genereeritavate andmete hulka.
    //Vastavalt sisestatud andmetele genereeritakse suvalislet etteantud vahemikus ja hulgal timestamp’e.

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            DateTime GetRandomDate(DateTime esimene, DateTime teine) //funktsioon
            {
                int vahe_days = (teine - esimene).Days;

                return esimene.AddDays(random.NextDouble() * vahe_days);
            }

            Console.WriteLine("random timestamps generator");
            Console.WriteLine();

            Console.Write("min aasta: ");
            int min_a = int.Parse(Console.ReadLine());

            Console.Write("max aasta: ");
            int max_a = int.Parse(Console.ReadLine());

            Console.Write("hulk: ");
            int hulk = int.Parse(Console.ReadLine());
            
            int a_vahe = max_a - min_a;

            DateTime esimene_a = new DateTime(min_a, 1, 1);
            DateTime teine_a = new DateTime(max_a, 12, 31);

            Console.WriteLine("timestamps: ");

            do
            {
                Console.WriteLine(GetRandomDate(esimene_a, teine_a));
                hulk--;
            }
            while (hulk > 0);

            Console.ReadLine();

        }
    }
}
