using System;

namespace Sample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var test1 = new TestCaseSerializeAndDeserialize();
            test1.Test();

            Console.WriteLine("Test 1 success");

            var test2 = new TestCasePagedListExtension();
            test2.Test();
            Console.WriteLine("Test 2 success");

            var rowConsoleText = Console.ReadLine();
        }
    }
}