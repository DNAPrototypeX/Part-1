using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 
            Console.WriteLine("1.");
            Console.WriteLine("P P P P     M M   M M");
            Console.WriteLine("P       P   M M   M M");
            Console.WriteLine("P       P   M   M   M");
            Console.WriteLine("P P P P     M       M");
            Console.WriteLine("P           M       M");
            Console.WriteLine("P           M       M");
            Console.WriteLine("P           M       M");
            Console.WriteLine("");

            //2. a)
            Console.WriteLine("2. a)");
            string firstName = "Paul";
            string favMovie = "The Matrix";
            string message = $"Hi, my name is {firstName}, and my favorite movie is {favMovie}.";
            Console.WriteLine(message.ToLower());
            Console.WriteLine("");

            //2. b)
            Console.WriteLine("2. b)");
            favMovie = favMovie.ToUpper();
            Console.WriteLine(favMovie);
            Console.WriteLine("");

            //2. c)
            Console.WriteLine("2. c)");
            Console.WriteLine(favMovie.Contains("THE"));
            Console.WriteLine("");

            //2. d)
            Console.WriteLine("2. d)");
            favMovie = favMovie.Replace("A", "@");
            favMovie = favMovie.Replace("E", "3");
            Console.WriteLine(favMovie);

        }
    }
}
