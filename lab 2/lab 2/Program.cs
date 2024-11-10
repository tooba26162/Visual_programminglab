using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //activity1
            Console.WriteLine($"there are {args.Length} arguments ");
            foreach (var item in args)
            {
                Console.WriteLine(item);

            }

            //activity 2
            Console.WriteLine("Hello world");
            Console.WriteLine("I am a BSCS student.");

            //activity 3
            
            Console.Write("enter year: ");
            int year=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(year);

        }
       
    }
}
