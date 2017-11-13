using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korrutustabel_6x6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("|   1   |  2   |  3   |  4   |  5   |  6   |");
            Console.WriteLine("--------------------------------------------");

            for (int a = 0; a <= 6; a++)
            {
                Console.Write(a +"/t");
            
                for (int b = 0; b <= 6; b++)
                {
                    if (a > 0)
                    {
                        Console.Write(a * b + "/t");
                    }
                    else
                    {
                        Console.Write(j + "/t");
                    }
                }
                    }

            Console.WriteLine("--------------------------------------------");

            Console.ReadLine();



            

           

        }
    }
}
