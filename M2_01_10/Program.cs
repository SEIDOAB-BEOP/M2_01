using System;

namespace BOOP_01_10
{
    class Program
    {
        public class Point
        {
            public int X, Y;        // data members
            public void WriteLine() // function member
            {
                Console.WriteLine(X + ", " + Y);
            }
        }
        public class Rectangle
        {
            public bool Visible;
            public Point TopLeft, BottomRight;
        }

        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle
            {
                Visible = true,
                BottomRight = new Point { X = 0, Y = 0 },
                TopLeft = new Point { X = 100, Y = 100 }
            };

            Console.WriteLine(rect.Visible);    // True
            rect.BottomRight.WriteLine();       // 0, 0
            rect.TopLeft.WriteLine();           // 100, 100
        }
    }
}
// Exercises:
// 1.   Create a new Console Project (Exercise0110) and its corresponding GitHub repository
// 2.   Copy the code from  Exercise0110 and make Stock a class instead of a struct
