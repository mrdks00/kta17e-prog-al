using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tunnikontrolli_exercise
{
class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("arvuta allahindlus  >  \n");

            string input = Console.ReadLine();
            double sum = double.TryParse(input);

                if (!Double.TryParse(input, out sum))
                    {
                    Console.WriteLine("SEE EI OLE SUMMA!");
                    Console.WriteLine("[a]gain or [q]uit?");
                    Console.ReadKey();
                    }
            
        double ale = 0;
        double ale1 = 0;

        if (sum >= 50 && sum < 250){
            ale = 10; ale1 = 20;
            }

        if (sum >= 250 && sum < 350){
            ale = 20; ale1 = 30;
            }

        if (sum >= 350){
            ale = 30; ale1 = 40;
            }

        var alesum = sum * ale / 100;
        var alesum1 = sum * ale1 / 100;
        var finalsum = sum - alesum;
        var finalsum1 = sum - alesum1;

        Console.WriteLine($"Tavakliendi ale: {ale}%");
        Console.WriteLine($"Tasuda: {finalsum}");
        Console.WriteLine();
        Console.WriteLine($"Püsiklient ale: {ale1}%");
        Console.WriteLine($"Tasuda: {finalsum1}");

        while (Console.ReadLine() != "q");
        }
    }
}
}
