using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            // string is a sequence oc hcaracters inside quotes and can be punct, numb, or letters
            // much like an array 

            Console.WriteLine("This is a tab \t.");
            Console.WriteLine("This is a \"quote\".");
            Console.WriteLine("This is a backslash \\");
            Console.WriteLine("This is a \n new line.");
            Console.WriteLine("This is a bell \a");

            string firstName = "Lakshami";
            string dogName = "Cleo";

            Console.WriteLine("My name is {0} and my dog is {1}.", firstName, dogName);
        }
    }
}
