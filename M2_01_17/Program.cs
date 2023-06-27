using System;

namespace BOOP_01_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int intVar1 = int.MaxValue;
            Console.WriteLine(intVar1); // 2147483647

            //Silent Overflow
            intVar1++;
            Console.WriteLine(intVar1); // -2147483648

            //Silent Underflow
            intVar1--;
            Console.WriteLine(intVar1); // 2147483647

            //Checked Overflow at run time
            checked
            {
                intVar1++;  
            }
        }
    }
}
// Exercises
// 1.   Step though the code using the debugger and monitor the value of intVar1.
//      - Check the overflow and underflow.
