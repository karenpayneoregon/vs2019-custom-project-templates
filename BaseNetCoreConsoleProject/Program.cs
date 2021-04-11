using System;
using BaseNetCoreConsoleProject.Helpers;
using ConsoleHelpers;

namespace BaseNetCoreConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColors.WriteHeader("Your header");
            ConsoleColors.EmptyLine();
            ConsoleColors.WriteGreen("TODO", false);
            ConsoleWaiter.ReadLineWithTimeout();
        }
    }
}
