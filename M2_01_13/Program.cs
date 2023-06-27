using System;

namespace BOOP_01_13
{
    class Program
    {
        struct myStruct
        {
            public int NonStaticValue;
            public static int StaticValue = 100;

            public void NonStaticMethod()
            {
                Console.WriteLine($"NonStaticValue = {NonStaticValue}, StaticValue = {StaticValue}");
            }
            public static void StaticMethod()
            {
                //Note: NonStaticValue is not accessable as this is a static method
                Console.WriteLine($"StaticValue = {StaticValue}");
            }
        }

        static void Main(string[] args)
        {
            //Access the static instance created by the CLR
            myStruct.StaticMethod(); // 100
            myStruct.StaticValue = myStruct.StaticValue + 50;
            myStruct.StaticMethod(); // 150


            //Create non-static instances
            var s1 = new myStruct { NonStaticValue = 1 };
            s1.NonStaticMethod(); // 1, 150

            var s2 = new myStruct { NonStaticValue = 2 };
            s2.NonStaticMethod(); // 2, 150

            myStruct.StaticValue = 200;
            s1.NonStaticMethod(); // 1, 200
            s2.NonStaticMethod(); // 2, 200
        }
    }
}
// Exercises:
// 1.   Discuss in the group and formulate in your own words, what is the difference between a static instance and an object instance.
// 2.   In your programs, Exercise0109 make a static decimal constant CommissionRate and set it to 2%.
// 3.   Caluclate the commision of the Stock, i.e. Price*Amount*CommisionRate and modify the WriteLine function() to
//      print out the Commission.
// 4.   From Main(), Print out the Constant CommisionRate.
// 4.   Make the same changes in Exercise0110
