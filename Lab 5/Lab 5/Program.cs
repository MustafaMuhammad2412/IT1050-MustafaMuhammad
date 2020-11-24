using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
{
    class Dog
    {
        public string Name { get; set; }

        public void bark()
        {
            Console.WriteLine("{0} is Barking...", Name);
        }

        public void doTrick(string trickName)
        {
            Console.WriteLine("{0} is so smart! {0} is doing a(n) {1}", Name, trickName);
        }
        static void Main(string[] args)
        {
            /* part 2 
             *
             * The scope of the method is a global scope due it have the "public" keyword signifying that it can be accessed from anywhere. It is a static method as it 
             * depends on the parameters height and width to return a value. The return type is a double value as your are multiplying two double values to get your final
             * return value. The method name is getArea and is assigned to be a double value using the double keyword, this tells us that the return value can have decimal
             * point and not be a simple integer. The parameters are hieght and width which are found inside the parentheses, they are the arguements we must supply when 
             * calling the method, both are double values. The method body is composed of a math equation where you multiply the two parameters and return the result as a 
             * double value to the method. 
             * 
             * part 3 
             * A user defined method is a method defined by us where we have to give the method type (public/private), what value will it return if any (bool, int, char, etc.),
             * what parameters there are, and then we must build the body of the method which is the task it is supposed to fulfill. We can access user defined methods by first
             * typing the class name and then using the method accessor (.) followed by the method name to run our method. A method provided in a framework can simply be 
             * accessed by a using directive followed by a namespace. With this we get access to all of the methods in that namespace and don't even have to use the fully 
             * quailified name to use them. This is an example of abstraction as we can use the methods but don't know how they work.
             * 
             * part 4
             * A static method doesn't not apply to any specific object but rather applies to a whole class. For example, a class of employees all could have the same type of 
             * email attribute which could then just be made using a static method. Since the same email format applies to all employees we could use a static method that does 
             * not depend on any data to work. The non static method is the complete opposite and requires data to function as well as only focusing on a specific object 
             * rather than the whole class.
             */

            //part 5
            Dog myDog = new Dog();
            myDog.Name = "Fido";

            myDog.bark();
            myDog.doTrick("Fetch");
            Console.ReadLine();
        }
    }
}
