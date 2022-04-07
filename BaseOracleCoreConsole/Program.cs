using System;
using System.Diagnostics;
using BaseOracleCoreConsole.Classes;
using static BaseOracleCoreConsole.Classes.Operations;

namespace BaseOracleCoreConsole
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Default connection string: {ConnectionString()}");
        }
    }
}
