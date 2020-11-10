using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratch_Files_for_practicing_code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mustafa's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string uservalue = Console.ReadLine();

            if (uservalue == "1") 
            {
                string message = "You won a new car!";
                Console.WriteLine(message);
            }
            else if (uservalue == "2")
            {
                string message = "You won a new boat!";
                Console.WriteLine(message);
            }
            else if (uservalue == "3")
            {
                string message = "You won a new cat!";
                Console.WriteLine(message);
            }

            Console.ReadLine();
        }
    }
}
