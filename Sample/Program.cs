using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var test1 = new TestCaseSerializeAndDeserialize();
            test1.Test();

            Console.WriteLine("Test 1 success");

            var test2 = new TestCaseSerializeAndDeserialize();
            test2.Test();
            Console.WriteLine("Test 2 success");

            var rowConsoleText = Console.ReadLine();
        }
    }
}
