using System;

namespace BOOP_01_14
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
            var point2 = new Point { X = 100, Y = 100 };

            point1.WriteLine();
            point2.WriteLine();

            //Console.WriteLine(Point.s_nrWriteLines);  // Error - Cannot be accessed 
            Point.NrWriteLines();
        }
    }
}
// Exercises:
// 1.   In Exercises Exercise0109 and Exercise0109 make the constant CommisionRate private.
//      - What changes do you have to make the progam compile and execute? Why? 
// 2.   Make the same changes in Exercise0110
