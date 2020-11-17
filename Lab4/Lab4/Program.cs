using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
          // part 2
          /* 1. Control Variable - a loop counter variable used to which is used to control the repitition
           * 2. Initial Value - The initial/beginning value of the control variable which is used to start the program 
           * 3. Loop Continuation Condition - The statement to determine if the loop should continue or not. A boolean value of True means to continue and False means to stop.
           * 4. Increment/Decrement Value - the control variable is modiifed through every iteration of the loop usually through iteration or decrementation. This doesn't occur in the first iteration and is done after the loop continuation statement.
           */

            // part 3 
            /*
             * A while loop continues to execute the statement as long as the loop continuation condition remains True, it is run an indefinite number of times and can 
             * run infinitely. The increment value is done in the body of the statemen, and the control variable is many times defined before the loop 
             * 
             * A for repition loop can also run until a condition becomes false but for a definite number of times. As long as the condition remains True it will run. 
             * Differently, the control variable, inital value, loop continuation condition, and increment value all can be defined in the header thus not requiring multiple lines
             */

            // part 4 
            /*
             * It's better to use a do-while statment when we require user input before we can begin the loop. For example, if we are making a trivia game where the user 
             * must answer questions presented by the computer, we have to ensure that the input is first stored in a value before we can do anything with it. So with the 
             * do while statement the program first runs to collect the users entry, then for example if the entry was not understood by the computer (error in spelling or 
             * invalid answer, etc.) then the loop will continously ask the user again and again to re-enter an answer until the computer recongizes it. This is better than 
             * a simple while loop because we are able to first get user input and then loop over it infinutely all in one block of code. Otherwise, we would first have to 
             * initialize our variable and then use the Readline() function to retrieve the answer, then we would have to run our loop make it much more cumbersome.
             */

            // part 5 

            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i);
                if ((i % 2) == 0) // it's even
                {
                    Console.WriteLine("  Even");
                }

                else
                {
                    Console.WriteLine("  Odd");
                }
            }
            Console.WriteLine();

            // part 6 

            Console.Write("Please enter a temperature: ");
            int temperature = Convert.ToInt32(Console.ReadLine());

            if (temperature < 10)
            {
                Console.WriteLine("Polar Bear");
            }
            else if (temperature < 20)
            {
                Console.WriteLine("Penguin");
            }
            else if (temperature < 40)
            {
                Console.WriteLine("Moose");
            }
            else if (temperature < 50)
            {
                Console.WriteLine("Raindeer");
            }
            else if (temperature < 60)
            {
                Console.WriteLine("Deer");
            }
            else if (temperature < 70)
            {
                Console.WriteLine("Turtle");
            }
            else if (temperature < 80)
            {
                Console.WriteLine("Lion");
            }
            else if (temperature < 90)
            {
                Console.WriteLine("Fish");
            }
            else
            {
                Console.WriteLine("Bug");
            }
            Console.WriteLine();

            // part 7
            // this was an infinite loop which can be fixed by simply adding an increment value
            int y = 10;
            while (y < 21)
            {
                Console.WriteLine(y);
                y++;
            }
            Console.WriteLine();

            // part 8 
            // this was a simply syntax error fix
            for (int x = 0; x < 101; x++)
            {
                Console.WriteLine(x);
                Console.WriteLine("********");
            }


            Console.ReadLine();
}
}
}
