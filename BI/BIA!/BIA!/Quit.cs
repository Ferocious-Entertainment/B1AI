﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIA_
{
    class Quit
    {
        public static void quit()
        {

            Console.WriteLine("Are you sure you want to close the program. Yes to confirm close, Press No to cancel.");

            if (Console.ReadKey(true).Key == ConsoleKey.Y)
                Environment.Exit(0);

            else if (Console.ReadKey(true).Key == ConsoleKey.N || Program.reconized == "No")
            {

                Program.Main();

            }
        }
    }
}
