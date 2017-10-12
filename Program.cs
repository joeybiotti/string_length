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

            if(value < 10)
            {
                Console.WriteLine("This number is too big");
            }
            else
            {
                Console.WriteLine("This number is big enough");
            }

            Console.ReadLine();
        }
    }
}
