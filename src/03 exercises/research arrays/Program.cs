using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace research_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //prindi: Vabanduste genereerimise programm
            Console.WriteLine("Vabanduste genereerimise programm");

            //prindi: sisesta komadega eraldatud vabandused
            Console.WriteLine("Sisesta komadega eraldatud vabandused: ");

            //prindi: > ja sain kasutaja sisendi
            Console.WriteLine(">");

            string input = Console.ReadLine();
                    
                    //string[] vabandused = new string[];
            string[] vabandused = input.Split(',');

            int random = new Random().Next(0, vabandused.Length);

            Console.WriteLine($"Tänane vabandus on: {vabandused[random]}");

            //oletame, et kasutaja sisestas: koer sõi ära, ema sõi ära, õde sõi ära, kass sõi ära, vanaema sõi ära

            //masiiv = input.Split(",")


            //Tänane vabandus on: {masiiv[random]}




            

            Console.ReadLine();
        }
    }
}
