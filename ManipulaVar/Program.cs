﻿using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(args[0]);
            x++;
            Console.WriteLine(x);
        }
    }
}
