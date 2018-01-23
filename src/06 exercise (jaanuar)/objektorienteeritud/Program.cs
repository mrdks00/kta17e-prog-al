using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objektorienteeritud
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Encoding.UTF8;

            Restaurant restaurant = new Restaurant("Taco palanque", "1200 Main ST.");

            Tab tab = new Tab();
            tab.Add(7.99);
            tab.Add(6.55);
            tab.Add(2.345);
            Reciept reciept = restaurant.GetReciept(tab);

            Console.Write(reciept);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }

    public class Tab
    {
        public List<double> Entries { get, private, set }

    }

    public class Reciept
    {
        

            }

    public class Restaurant
    {
        private string _restaurantName;
        private string _restaurantaddress;

        public Restaurant(string name, string address)
        {
            this._restaurantName = name;
            this._restaurantaddress = address;
        }
    }
    public override string ToString()
    {

    var sb = new StringBuilder();
        sb.appendLine("this_restaurantName");
            sb.appendLine"this_restauranrAddress");
        
    }
}
