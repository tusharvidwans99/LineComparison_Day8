﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison_Day8
{
    public class CompareLineLength
    {
        int x1, y1, x2, y2;
        public void get()
        {
            Console.WriteLine("Enter X start coordinate number of line1 i.e x1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y start coordinate number of line1 i.e y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter X end coordinate number of line i.e x2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y end coordinate number of line1 i.e y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            MesuretheLength(x1, y1, x2, y2);
        }
        public static void MesuretheLength(int x1, int y1, int x2, int y2)
        {

            double lengthofLine = Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)),4);
            Console.WriteLine(lengthofLine);
        }

    }
}