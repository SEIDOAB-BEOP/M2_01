using System;

namespace BOOP_01_15
{
    class Program
    {
         static void Main(string[] args)
        {
            int y = 5 * 2 + 24 / 3 - 2; // mathematical order of precedence
            int x = 2;
            Console.WriteLine(y);       // 16
            Console.WriteLine(x);       // 2

            y = 5 * (x = 3) + 24/4;    // you may incorporate an assignment value into an expression
            Console.WriteLine(y);      // 21
            Console.WriteLine(x);      // 3

            Console.WriteLine(5 / 3);  // 3/3 + 2/3 => 1 + 2/3 => 1 truncated to int 
            Console.WriteLine(5 % 3);  // the reminder 2 from 2/3 

            //repeat cycling 3 items regardless of increment value
            Console.WriteLine(0 % 3);  // 0
            Console.WriteLine(1 % 3);  // 1 
            Console.WriteLine(2 % 3);  // 2
            Console.WriteLine(3 % 3);  // 0
            Console.WriteLine(4 % 3);  // 1
            Console.WriteLine(5 % 3);  // 2
            Console.WriteLine(6 % 3);  // 0

            // % to test even or odd numbers
            Console.WriteLine(8 % 2);  // even so % is 0 
            Console.WriteLine(7 % 2);  // odd so % is 1 

            Console.WriteLine(46 % 2);  // even so % is 0 
            Console.WriteLine(57 % 2);  // odd so % is 1 
        }
    }
}