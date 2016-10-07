using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_formatering
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Övning 1
            DateTime dt = new DateTime(2016, 10, 07);
            Console.WriteLine(dt.ToString("d"));
            */

            /* Övning 2
            double tal = 4 * 4 * Math.PI;
            Console.WriteLine(tal.ToString("F4"));
            */

            /* Övning 3 
            Console.WriteLine("{0:0,0}", 1000000000);
            */

            /* Övning 4
            double value = 123;
            Console.WriteLine("Det blir {0} kr och 00 öre", value);
            */
            
            /* Övning 5
            Console.Write("Skriv in hela ditt personnummer (12 siffror): ");
            string inmatat = Console.ReadLine();
            long tal = long.Parse(inmatat);
            Console.WriteLine("{0:####-##-##-####}", tal);
            */
            
        }
    }
}
