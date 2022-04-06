﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BaseCoreConsoleApp.Classes;


// ReSharper disable once CheckNamespace
namespace BaseCoreConsoleApp
{
    /// <summary>
    /// Make this console window full-screen, set title
    /// </summary>
    public partial class Program
    {
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static readonly IntPtr ThisConsole = GetConsoleWindow();
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(System.IntPtr hWnd, int cmdShow);
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = Operations.ApplicationSettings().Title;
            if (Operations.ApplicationSettings().FullScreen)
            {
                ShowWindow(ThisConsole, 3);
            }
            
        }
    }
}
