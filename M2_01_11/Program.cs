using System;

namespace BOOP_01_11
{
    class Program
    {
        public struct Point
        {
            public int X, Y;        // data members
        }
        static void Main(string[] args)
        {
            // all initialized to 0
            int intVar1 = default;
            float floatVar1 = default;
            Point pointVar1 = default;

            // uninitilized and cannot be referenced
            double doubleVar1;

            Console.WriteLine(intVar1);                          // 0
            Console.WriteLine(floatVar1);                        // 0
            Console.WriteLine(pointVar1.X + ", " + pointVar1.Y); // 0, 0

            //Console.WriteLine(doubleVar1);  // Compiler Error
        }
    }
}
