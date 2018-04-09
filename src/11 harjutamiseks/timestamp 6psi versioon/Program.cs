using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timestamp_6psi_versioon
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;

            //var date = DateTime.Parse("09.04.2018 09:28:10");
            Console.WriteLine($"Day: {DateTime.Day}");
            Console.WriteLine($"Month: {DateTime.Month}");
            Console.WriteLine($"Hour: {DateTime.Hour}");
            Console.WriteLine($"Minute: {DateTime.Minute}");

            //Console.WriteLine(DateTime.Now.ToString);
        }
    }
}
