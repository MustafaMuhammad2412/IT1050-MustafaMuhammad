using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // part 2
            int first_factor;
            int second_factor;
            int product;
            
            Console.Write("Enter first integer: ");
            first_factor = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer: ");
            second_factor = Convert.ToInt32(Console.ReadLine());

            product = first_factor * second_factor;

            Console.WriteLine("Product is {0}", product);

            // part 3
            Console.WriteLine("{0}\n{1}", "Hello World!", "From Mustafa");

            // part 4
            Console.WriteLine("{0}\t{1}", "Hello World!", "From Mustafa");
            Console.ReadLine();
            // part 5
/*
 * 1. Our application begins execution with the Main() method (can be referred to as "starting point")
 * 
 * 2. An integer type holds integers or whole numbers ex. 3 or 18  Range of values is from -2,147,483,648 to +2,147,483,647
 *    Double/floating-point variables store values that may contain decimals ex. 0.5 or 58.63
 *    
 * 3. In chapter 4 one method was Deposit. It allows the client to deposit money into an Account, thus increasing their balance.
 * 
 * 4. To read the value of an instance variable, we create a method called a get accessor. To assign a value to an instance variable, we create a method called a set accesor
 *
 * 5. A class is a template used to make instances of that class. It can define attributes of the object such as "age" or "height", or any range of values.
 *    
 *    An object is an instance of its class. The object's attributes are defined by the blueprint/template created in the class, they can be defined by you or have a default value.
 *    In short, we use classes to make instances/objects which model real entities (an employee or coffee mug, anything you wish!). We make objects with the new keyword followed by the name of it's class (preceeded by the object type)
 *    
 *    We can create as many objects as we like but each object is unique because of it's attributes, and the specific place where it is stored in memory. Thus, you can have unlimited object simply by using the new keyword, but every object is different.
 */
}
}
}
