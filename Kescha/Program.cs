﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kescha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name : ");
            string name = Console.ReadLine();
            Console.Write("Enter your first name : ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hello {name} {firstName}, Sizning yoshingiz {age} da ekan");
        }
    }
}
