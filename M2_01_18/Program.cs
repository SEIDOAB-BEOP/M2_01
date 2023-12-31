﻿using System;

namespace BOOP_01_18
{
    class Program
    {
        static void Main(string[] args)
        {
            // Unlike integral types, floating-point types have values that certain operations treat specially,
            // namely NaN (Not a Number), +∞, −∞, and −0:
            Console.WriteLine(double.NegativeInfinity);   // -8 = -Infinity

            // Dividing a nonzero number by zero results in an infinite value:
            Console.WriteLine(1.0 / 0.0);     //  8 = Infinity
            Console.WriteLine(-1.0 / 0.0);     // -Infinity
            Console.WriteLine(1.0 / -0.0);     // -Infinity
            Console.WriteLine(-1.0 / -0.0);    //  Infinity

            // Dividing zero by zero, or subtracting infinity from infinity, results in a NaN:
            Console.WriteLine(0.0 / 0.0);                  //  NaN
            Console.WriteLine((1.0 / 0.0) - (1.0 / 0.0));   //  NaN

            // When using ==, a NaN value is never equal to another value, even another NaN value:
            Console.WriteLine(0.0 / 0.0 == double.NaN);    // False

            // To test whether a value is NaN, you must use the float.IsNaN or double.IsNaN method:
            Console.WriteLine(double.IsNaN(0.0 / 0.0));   // True
        }
    }
}
