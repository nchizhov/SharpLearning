﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("***** My First C# App *****");
            Console.WriteLine("Hello World");
            Console.WriteLine();

            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (string arg in theArgs)
                Console.WriteLine("Arg: {0}", arg);

            ShowEnvironmentDetails();

            Console.ReadLine();

            return -1;
        }

        static void ShowEnvironmentDetails()
        {
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);

            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".Net Version: {0}", Environment.Version);
        }
    }
}
