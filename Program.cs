using System;
namespace RemoveSpecialChars
{
    public class Program
    {
        public static string RemoveSpecialChars(string input, char[] targets)
        {
            string[] subStrings = input.Split(targets);
            string output = "";
            foreach (string subString in subStrings)
            {
                output = String.Concat(output, subString);
            }
            return output;
        }
        public static void Main(string[] args)
        {
            string input = "this is a!@ test. Remove # special % chars";
            char[] targets = { '!', '@', '#', '%', '.' };

            string result = RemoveSpecialChars(input, targets);
            Console.WriteLine("Original string: " + input);
            Console.WriteLine("Processed string: " + result);
            Console.WriteLine("Press 'Enter' to over");
            Console.Read();
        }
    }
}