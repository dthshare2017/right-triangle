﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace right_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please put your high of the triangle here: ");
            int n = int.Parse(Console.ReadLine());
            draw_right_triangle(n);
        }

        static void draw_right_triangle(int n)
        {
            Console.WriteLine("your high of triangle is: " + n);
            Console.WriteLine("-----------");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j <= r; j++)
            //    {
            //        if (j > n - 1 - i && j <= r - (n - 1 - i))
            //            Console.Write("*");
            //        //else Console.Write(" ");
            //    }
            //    Console.WriteLine("");
            //}
            Console.ReadLine();
        }
    }
}
