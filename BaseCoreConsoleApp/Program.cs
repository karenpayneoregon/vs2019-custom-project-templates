using System;
using static BaseCoreConsoleApp.Classes.Operations;

namespace BaseCoreConsoleApp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Default connection string: {ConnectionString()}");
            Console.ReadLine();
        }
    }
}
