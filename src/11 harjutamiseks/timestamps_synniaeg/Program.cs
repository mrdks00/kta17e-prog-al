using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace timestamps_synniaeg
{
    //Ülesanne 4
    //Programmis on defineeritud masiiv mis sisaldab umbes 30 erinevat timestamp’i mis illustreerivad inimeste sünniaega, 
    //näiteks vahemikus alates 1940 – 2010. Programmi ülesanne on leida nende timestamp’ide põhjal:
    //maksimaalne vanus
    //keskmine vanus aastates
    //minimaalne vanus
    //millisel kuul on kõige rohkem sünnipäevi
    //kõik timestamp’id sorteerituna kasvavalt

    class Program
    {
        /*public static double DateTimeToUnixTimestamp(DateTime dateTime)
        {
            return (TimeZoneInfo.ConvertTimeToUtc(dateTime) -
                     new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc)).TotalSeconds;
        }
        */
       
            // appi aia 

        static void Main(string[] args)
        {
            string dateString = "05/03/1992 21:24:21";

         
           // 05 / 03 / 1992 21:24:21

            Console.ReadLine();

            /*DateTime praegu = DateTime.Now;

            TimeSpan currentOffset = localZone.GetUtcOffset(currentDate);
            
            int[] timest2mbid = int[] { 20 / 03 / 1989 06:23:11, 
     27 / 03 / 2008 21:04:31,
     19 / 06 / 1978 15:26:59,
     20 / 12 / 1995 16:28:55
     10 / 04 / 1944 20:23:30
     24 / 08 / 1971 21:05:09
     04 / 02 / 1956 19:59:51
     10 / 02 / 1972 05:40:46
     13 / 12 / 1992 09:27:19
     06 / 01 / 2000 16:27:13
     12 / 07 / 2007 20:21:31
     29 / 07 / 1955 22:40:33
     24 / 04 / 2001 00:39:43
     13 / 09 / 2007 00:18:44
     14 / 10 / 1993 00:20:05
     01 / 02 / 1947 16:14:20
     21 / 09 / 1948 01:34:13
     17 / 09 / 2006 13:36:11
     23 / 09 / 1966 14:12:48
     16 / 03 / 1985 13:27:31
     02 / 02 / 1971 22:56:11
     03 / 08 / 1957 16:56:30
     08 / 07 / 1988 07:53:01
     25 / 01 / 1991 22:32:14
     05 / 08 / 1976 05:49:59
     01 / 01 / 1970 17:09:29
     11 / 01 / 1958 11:49:21
     24 / 06 / 1946 13:04:58
     06 / 01 / 1971 21:11:14
                 };*/

            Console.Write("maksimaalne vanus: ");
            Console.Write("keskmine vanus aastates: ");
            Console.Write("minimaalne vanus: ");
            Console.Write("Kuu on kõige rohkem sünnipäevi: ");
            Console.Write("kõik timestamp’id sorteerituna kasvavalt: ");

            Console.WriteLine();
        }
    }
}
/*Random random = new Random();

            DateTime GetRandomSynniaeg(DateTime algus_a, DateTime l6pp_a) 
            {
                int vahe_days = (l6pp_a - algus_a).Days;
                return algus_a.AddDays(random.NextDouble() * vahe_days);
            }

            DateTime algus = new DateTime(1940, 1, 1);
            DateTime l6pp = new DateTime(2010, 12, 31);
            
            int synniaeg_count = 0;

            do {
                while (synniaeg_count <= 30)
                {
                    Console.Write("> ");
                    Console.WriteLine(GetRandomSynniaeg.Next(algus, l6pp));
                    synniaeg_count++;
                }    
                if (synniaeg_count == 31)
                {
                    break;
                }
            }*/