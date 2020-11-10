using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* part 2
             * The if statement and while loop are similar as they allow you to perform a statment or a series of statements based on if a condition is 
             * true or false. They are the foundation of programming.
             * They are different because the if statement will perform a statement once as long as they condtion is true and then will move onto the next block of code
             * The while loop will keep on performing a statement as long as the condition is true, and will stop if it is false. Then it will move on
             */

            // part 3
            int speedLimit = 35;
            int speed = 42;

            if (speed > speedLimit)
            {
                Console.WriteLine("SLOW NOW");
            }
            Console.WriteLine();

            // part 4
            bool isTrue;

            int firstNum = 4;
            int secondNum = 5;

            Console.WriteLine("{0} > {1}", firstNum, secondNum);
            if (firstNum > secondNum)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }

            if (isTrue)
            {
                Console.WriteLine("It is True!");
            }
            else
            {
                Console.WriteLine("It is False!");
            }
            /*
            bool isTrue;
                             simply switch the two integers to get True
            int firstNum = 5;
            int secondNum = 4;

            Console.WriteLine("{0} > {1}", firstNum, secondNum);
            if (firstNum > secondNum)
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }

            if (isTrue)
            {
                Console.WriteLine("It is True!");
            }
            else
            {
                Console.WriteLine("It is False!");
            }
            */
            Console.WriteLine();

            // part 5
            Console.Write("Enter a temperature in Fahrenheit: ");
            double Fahrenheit = Convert.ToDouble(Console.ReadLine());

            double Celsius;
            Celsius = (Fahrenheit - 32d) * 5d / 9d;

            Console.WriteLine("Temperature in Celsius: {0}", Celsius);
            if (Fahrenheit < 40)
            {
                Console.WriteLine("It is cold");
            }
            if (Fahrenheit > 90)
            {
                Console.WriteLine("It is hot");
            }
            Console.WriteLine();

            // part 6
            int num = 1;

            while(num <= 10)
            {
                Console.WriteLine(num);
                num++;
            }
            Console.WriteLine();

            // part 7
            int x = 60;

            while (x >= 20)
            {
                Console.WriteLine(x);
                x -= 5;
            }
            Console.WriteLine();

            // part 8
            int y = 10;

            while (y <= 20)
            {
                Console.WriteLine(y);
                y += 2;
            }

            Console.ReadLine();
        }   
           
    }
}
