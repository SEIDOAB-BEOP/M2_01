using System;

namespace BOOP_01_14a
{
    class Program
    {
        public struct Point
        {
            public int X, Y;                       // instance data members
            private static int s_nrWriteLines = 0; // private static datamember

            public void WriteLine()                // instance function member
            {
                s_nrWriteLines = s_nrWriteLines + 1;
                Console.WriteLine(X + ", " + Y);
            }
            public static void NrWriteLines()       // static function member
            {
                Console.WriteLine(s_nrWriteLines);
            }
        }

        static void Main(string[] args)
        {
            var point1 = new Point { X = 0, Y = 0 };

            Type type1 = typeof(Point);         // Get the type object from a Type
            Type type2 = point1.GetType();      // Get the type object from a variable

            Console.WriteLine(type1.FullName);  // BOOP_01_14a.Program+Point
            Console.WriteLine(type1.Namespace); // BOOP_01_14a

            Console.WriteLine(type2.FullName);  // BOOP_01_14a.Program+Point
            Console.WriteLine(type2.Namespace); // BOOP_01_14a
        }
    }

    // Exercises
    // 1.   In Exercise0109 to create a variable of Type for Stock 
    // 2.   Explore some function members of the Type objects created from 1.
}
