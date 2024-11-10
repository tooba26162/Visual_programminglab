using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //activity1
            ExploringNumbers();


            //activity2
            assignLocalVariables();


            //activity3
            typeConversions();
        }

        static void typeConversions()
        {
            int number1, number2, number3;

            Console.Write("Enter first number: ");
            string str1=Console.ReadLine();
            number1 = Convert.ToInt32(str1);


            Console.Write("Enter second number: ");
            number2=Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter third number: ");
            number3=Int32.Parse(Console.ReadLine());

            Console.WriteLine("num1:{0} , num2:{1} , num3:{2} " ,number1,number2,number3);

        }
        static void assignLocalVariables()
        {
            int population = 66_000_000;
            double weight = 1.88;
            decimal price = 1.8M;
            string Name = "Tooba";
            char letter = 'z';
            bool happy = true;
        }
        static void ExploringNumbers()
        {
            Console.WriteLine($" int uses {sizeof(int)} bytes and can stores numbers in the range \n\n:" + $"{int.MinValue} to {int.MaxValue} \n");

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($" int uses {sizeof(double)} bytes and can stores numbers in the range \n\n:" + $"{double.MinValue} to {double.MaxValue} \n");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($" int uses {sizeof(decimal)} bytes and can stores numbers in the range \n\n:" + $"{decimal.MinValue} to {decimal.MaxValue} \n");

        }
    }
}
