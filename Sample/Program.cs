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
            var test = new TestCaseSerializeAndDeserialize();
            test.Test();
            Console.WriteLine("Test success");
            var rowConsoleText = Console.ReadLine();
        }
    }
}
