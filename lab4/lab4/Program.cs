using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //activity 1
            if (args.Length == 0)
            {
                Console.WriteLine("there are not arguments");
            }
            else
            {
                Console.WriteLine("there is atleast one argumnet");

                if (args.Length < 3)
                {
                    Console.WriteLine("not enough arguments");
                }
            }

            //activity2
            ImplementDoWhileLoop();

            //activity3
            ImplementForEachLoop();

        }
        static void ImplementForEachLoop()
        {
            string[] names = { "adam", "tooba", "aiman" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }
        static void ImplementDoWhileLoop()
        {
            string password=string.Empty;
            do
            {
                Console.Write("Enter password: ");
                password = Console.ReadLine();

            }
            while (password != "secret");
            Console.WriteLine("Good job");

        }
        
    }

}
