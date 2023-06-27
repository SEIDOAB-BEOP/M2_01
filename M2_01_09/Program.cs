using System;

namespace BOOP_01_09
{
    class Program
    {
        public struct Point
        {
            public int X, Y;        // data members
            public void WriteLine() // function member
            {
                Console.WriteLine(X + ", " + Y);
            }
        }
        public struct Rectangle
        {
            public bool Visible; 
            public Point TopLeft, BottomRight;
        }

        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle { Visible = true, 
                BottomRight = new Point { X = 0, Y = 0 }, TopLeft = new Point { X = 100, Y = 100 } };
            
            Console.WriteLine(rect.Visible);    // True
            rect.BottomRight.WriteLine();       // 0, 0
            rect.TopLeft.WriteLine();           // 100, 100
        }
    }
}
// Exercises:
// 1.   Create a new Console Project (Exercise0109) and its corresponding GitHub repository
// 2.   Create a new Console Project and Git repository  and Mimick above code to declare a struct called Stock that contains
//      one string variable, Name, (Name of the stock) and
//      one decimal variable, Price, (Price of the stock) and
//      one int variable Amount (number of stocks)
// 3.   Mimick above code to create a variable, myStock, of type Stock where Name = "SAS", Price = 1.9915, Amount = 1000
// 4.   Mimick above code to include in a struct Stock a function called WriteLine () that writes
//      "You have 1000 stocks of SAS. Total value is 1991.5 kr"
