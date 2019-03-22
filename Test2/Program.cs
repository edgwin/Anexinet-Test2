using System;
using System.Collections.Generic;
using FizzBuzzLibrary;

namespace Test2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var FizzBuzz = new FizzBuzz();
            var message = "Failed";
            var tokens = new Dictionary<int, string>();
            tokens.Add(3, "Fizz");
            tokens.Add(5, "Buzz");
            var result = FizzBuzz.Execute(1, 200, tokens, ref message);
            if (result != null)
                result.ForEach(list => Console.Write("{0}\n", list));
            Console.WriteLine("\n" + message);
            Console.ReadLine();
        }
    }
}
