using System;
using System.Drawing;
using ConsoleHelpers;
using static System.Console;

namespace BaseNetCoreConsoleProject.Helpers
{
    public static class ConsoleColors
    {
        /// <summary>
        /// Write text in rectangle at top of console screen
        /// </summary>
        /// <param name="message">Text to display</param>
        public static void WriteHeader(string message)
        {
            var item = new ConsoleRectangle(message,100, 1, new Point(0, 0));
            item.Draw();
        }
        public static void WriteYellow(string message, bool line = true)
        {

            ForegroundColor = ConsoleColor.Yellow;
            WriteLine(message);
            ResetColor();
            AddDashLine(line);
        }


        public static void WriteWhite(string message, bool line = true)
        {

            ForegroundColor = ConsoleColor.White;
            WriteLine(message);
            ResetColor();
            AddDashLine(line);
        }
        public static void WriteRed(string message, bool line = true)
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine(message);
            ResetColor();
            AddDashLine(line);
        }
        public static void WriteMagenta(string message, bool line = true)
        {
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine(message);
            ResetColor();
            AddDashLine(line);
        }
        public static void WriteGreen(string message, bool line = true)
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine(message);
            ResetColor();
            AddDashLine(line);
        }
        public static void WriteGray(string message, bool line = true)
        {
            ForegroundColor = ConsoleColor.Gray;
            WriteLine(message);
            ResetColor();
            AddDashLine(line);
        }
        public static void WriteDarkYellow(string message, bool line = true)
        {
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine(message);
            ResetColor();
            AddDashLine(line);
        }
        public static void WriteDarkRed(string message, bool line = true)
        {
            ForegroundColor = ConsoleColor.DarkRed;
            WriteLine(message);
            ResetColor();
            AddDashLine(line);
        }
        public static void WriteDarkMagenta(string message, bool line = true)
        {
            ForegroundColor = ConsoleColor.DarkMagenta;
            WriteLine(message);
            ResetColor();
            AddDashLine(line);
        }
        public static void WriteDarkGreen(string message, bool line = true)
        {
            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine(message);
            ResetColor();
            AddDashLine(line);
        }
        public static void WriteDarkDarkGreen(string message, bool line = true)
        {
            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine(message);
            ResetColor();
            AddDashLine(line);
        }
        public static void WriteDarkCyan(string message, bool line = true)
        {
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine(message);
            ResetColor();
            AddDashLine(line);
        }
        public static void WriteDarkBlue(string message, bool line = true)
        {
            ForegroundColor = ConsoleColor.DarkBlue;
            WriteLine(message);
            ResetColor();
            AddDashLine(line);
        }
        public static void WriteCyan(string message, bool line = true)
        {
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine(message);
            ResetColor();
            AddDashLine(line);
        }
        public static void WriteBlue(string message, bool line = true)
        {
            ForegroundColor = ConsoleColor.Blue;
            WriteLine(message);
            ResetColor();
            AddDashLine(line);
        }
        public static void WriteBlack(string message, bool line = true)
        {
            ForegroundColor = ConsoleColor.Black;
            WriteLine(message);
            ResetColor();
            AddDashLine(line);
        }
        public static void PressAnyKey(string message = "Press any key to exit")
        {
            ForegroundColor = ConsoleColor.White;
            WriteLine(message);
            ResetColor();
        }
        public static void PressAnyKeyAndWait(string message = "Press any key to exit")
        {
            ForegroundColor = ConsoleColor.White;
            WriteLine(message);
            ResetColor();
            EmptyLine();
            ReadLine();
        }

        public static void WriteIndented(string message)
        {
            WriteLine($"\t{message}");
        }
        public static void WriteIndented(int value)
        {
            WriteLine($"\t{value}");
        }
        public static void WriteIndented(decimal value)
        {
            WriteLine($"\t{value}");
        }
        public static void WriteIndented(double value)
        {
            WriteLine($"\t{value}");
        }
        public static void WriteIndented(bool message)
        {
            WriteLine($"\t{message}");
        }
        /// <summary>
        /// Write empty line
        /// </summary>
        public static void EmptyLine()
        {
            WriteLine("");
        }
        /// <summary>
        /// Add dashed line to console
        /// </summary>
        /// <param name="line"></param>
        private static void AddDashLine(bool line)
        {
            if (line)
            {
                WriteLine(new string('-', 100));
            }
        }

    }
}