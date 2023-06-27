using System;

namespace BOOP_01_19
{
    class Program
    {
        static void Main(string[] args)
        {
            // Unlike decimal, float and double can cannot precisely represent numbers fractional component
            float x = 0.1f;                                             // Not quite 0.1
            float xNotQuite = x + x + x + x + x + x + x + x + x + x;
            Console.WriteLine(xNotQuite);   // 1.0000001

            decimal y = 0.1m;  // Exactly 0.1
            decimal yExactly = y + y + y + y + y + y + y + y + y + y;
            Console.WriteLine(yExactly);   // 1.0

            // Neither double nor decimal can precisely represent an inifinte fractional number
            decimal m = 1M / 6M;              
            double d = 1.0 / 6.0;             
            Console.WriteLine(m);                   // 0.1666666666666666666666666667M
            Console.WriteLine(d);                   // 0.16666666666666666

            // This leads to accumulated rounding errors:
            decimal notQuiteWholeM = m + m + m + m + m + m;  
            double notQuiteWholeD = d + d + d + d + d + d;  
            Console.WriteLine(notQuiteWholeM);      // 1.0000000000000000000000000002M
            Console.WriteLine(notQuiteWholeD);      // 0.99999999999999989

            // which breaks equality and comparison operations:
            Console.WriteLine(notQuiteWholeM == 1M);   // False
            Console.WriteLine(notQuiteWholeD < 1.0);   // True
        }
    }
}
// Exercises
// 1.   Step though the code using the debugger and monitor the value
//      -- Do you understand the difference between xNotQuite and yExactly and the difference bweteen m and d?
