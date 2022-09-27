﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sept23_Assignment
{
    public class Division
    {
        double res;

        public Division()
        {
            res = 0;
        }
        public void div(double n1, double n2)
        {
            try
            {
                res = n1 / n2;

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }

    public class Square_root
    {
        double SquareRoot;

       
        public void square_root_num(double num)
        {
            SquareRoot = Math.Sqrt(num);
            Console.WriteLine($"Square Root of {num}: {SquareRoot}");
        }
    }
    internal class Q2
    {
         static void Main(string[] args)
        {
            Square_root sqrt = new Square_root();

            double num = Convert.ToDouble(Console.ReadLine());

            sqrt.square_root_num(num);

            Division d = new Division();

            d.div(num, 0);
        }

    }
}
