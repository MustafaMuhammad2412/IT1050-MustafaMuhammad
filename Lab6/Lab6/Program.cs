using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            // part 2 
            /*
             A one-dimensional array p contains four elements. The array access expressions to access each 
             of the elements in p are __p[0]__, ___p[1]___,____p[2]___ and __p[3]____. 
            */

            // part 3 
            string[] months = new string[12];
            months[0] = "January";
            months[1] = "February";
            months[2] = "March";
            months[3] = "April";
            months[4] = "May";
            months[5] = "June";
            months[6] = "July";
            months[7] = "August";
            months[8] = "September";
            months[9] = "October";
            months[10] = "November";
            months[11] = "December";

            for (int x = 0; x < months.Length; x++)
            {
                Console.WriteLine(x + " : " + months[x]); 
            }

            // part 4
            string[] seasons = new string[4];
            seasons[0] = "Summer";
            seasons[1] = "Fall";
            seasons[2] = "Winter";
            seasons[3] = "Spring";

            foreach (string season in seasons)
            {
                Console.WriteLine(season);
            }

            //part 5
            Random random = new Random();
            int[] randomNumber = new int[1000];
            
            for (int i = 0; i < randomNumber.Length; i++)
            {
                randomNumber[i] = random.Next(0, 100);
            }
            foreach (int i in randomNumber)
            {
                Console.WriteLine(i);
            }

            //part 6
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int y = 0;
            while (y < names.Length)
            {
                Console.WriteLine(names[y]);
                y++;
            }

            // part 7
            string[] name = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int z = 0;
            while (z < name.Length)
            {
                Console.WriteLine("{0,2}. {1}", z, name[z]);
                z++;
            }

            // part 8
            /*
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            a = 0
            foreach (string i in names)
            {
                Console.WriteLine("{0,2}. {1}", a, names[i]);
                a++
            }

             */

            Console.ReadLine();
        }
    }
}