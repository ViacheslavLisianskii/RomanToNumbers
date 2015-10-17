using System;

namespace RomanToNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var number = Roman.ConvertToNumber(args[0]);

            Console.WriteLine("{0} => {1}", args[0], number);
        }

        private static readonly Roman Roman = new Roman();
    }
}
