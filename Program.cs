using System;

namespace string_big_or_small
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
           
            string line = Console.ReadLine();
           
            int value;
            Int32.TryParse(line, out value);

            if(value > 100)
            {
                Console.WriteLine("Woah! This number is too big. Let's dial it back a bit.");
            }
            else
            {
                Console.WriteLine("C'mon. This number is way too small. Get serious.");
            }

            Console.ReadLine();
        }
    }
}
