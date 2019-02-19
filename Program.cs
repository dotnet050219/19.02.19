using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1902
{
    class Program
    {
        static void Main(string[] args)
        {
            //// comment one line
            ///*
            // 1
            // 2
            // 3
            // 4
            // */
            //Console.WriteLine("Hello World!");

            //int a = 5;
            //int b = a * 66;
            //float f = 5.5f;
            //double d = a * b * f;
            //Console.WriteLine(d);

            /*
            // in 3 lines
            int x;

            // str get get a string from the user 
            string str = Console.ReadLine(); // readline gets a string from the user

            x = Convert.ToInt32(str); // coverts the str text into a string -> put it in x 

            // in 1 line
            int z = Convert.ToInt32(Console.ReadLine());

            int y = x * 2;

            Console.WriteLine(y);

            

            // read number print ugi / e-zugi

            Console.Write("Please enter a number (zugi check): ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                // YES
                Console.WriteLine("the number is zugi");
            }
            else
            {
                // NO
                Console.WriteLine("the number is e zugi");
            }

            

            Console.Write("Enter number fo digit check: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x >= 0 && x <= 9)
            {
                // YES
                Console.WriteLine("1 digit");
            }
            else if (x >= 10 && x <= 99)
            {
                // YES
                Console.WriteLine("2 digits");
            }
            else
            {
                // Everything before was not true
                Console.WriteLine("3 or more digits...");
            }

            

            int a, b, c;
            Console.WriteLine("Enter 3 numbers and i will give you the biggeset (equal)");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine(a + " is the biggest!");
            }
            else if (b > c)
            {
                Console.WriteLine(b + " is the biggest!");
            }
            else
            {
                Console.WriteLine(c + " is the biggest!");
            }
            

            

            int x;
            int sum = 0;
            Console.WriteLine("Enter numbers for accumalation (negative to exit):");

            x = Convert.ToInt32(Console.ReadLine());

            while ( x >= 0 )
            {
                sum = sum + x;

                x = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Sum = " + sum);
            
            int x;
            double sum = 0;
            int i = 0;
            Console.WriteLine("Enter numbers for average (negative to exit):");

            x = Convert.ToInt32(Console.ReadLine());

            while (x >= 0)
            {
                sum = sum + x;
                i++;

                x = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Average = " + sum / i);
            */
            int x = 1;
            int a, b;
            do
            {
                Console.WriteLine(x); // i know x
                Console.WriteLine("Please give 2 numbers till the sum of them is 100");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
            }
            while (a + b != 100);

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

        }
    }
}
