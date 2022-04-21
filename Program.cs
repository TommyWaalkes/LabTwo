using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hey user what time is it?");
            int time;
            try
            {
                string input = Console.ReadLine();
                time = int.Parse(input);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("That is not a valid number");
                Console.WriteLine("Lets assume its 12pm");
                time = 12;
            }
            Console.WriteLine(time);
            Console.WriteLine("hi");
            Console.WriteLine();
            Console.WriteLine("Hey do you want a coat?");
            string input2 = Console.ReadLine();
            if(input2 == "yes")
            {
                Console.WriteLine("Here is your coat friend!");
            }
            else if (input2 =="maybe")
            {
                Console.WriteLine("Come on make up your mind!");
            }
            else
            {
                Console.WriteLine("Nevermind, have a nice day!");
            }
        }
    }
}
