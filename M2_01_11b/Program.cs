using System;

namespace BOOP_01_11b
{
    class Program
    {
        class aClass { public int aValue; public int bValue; }
        static void Main(string[] args)
        {
            //Assignment Reference Type (array)
            int[] array_a = { 1, 10 };
            int[] array_b = { 2, 20 };

            array_b = array_a;
            array_a[0] = 3;
            array_a[1] = 30;

            Console.WriteLine($"array_a: {array_a[0]}, {array_a[1]}"); // 3, 30
            Console.WriteLine($"array_b: {array_b[0]}, {array_b[1]}"); // 3, 30
            Console.WriteLine();


            //Assignment Reference Type (class)
            aClass aclass_a = new aClass { aValue = 1, bValue = 10 };
            aClass aclass_b = new aClass { aValue = 2, bValue = 20 };

            aclass_b = aclass_a;
            aclass_a.aValue = 3;
            aclass_a.bValue = 30;

            Console.WriteLine($"class_a: {aclass_a.aValue}, {aclass_a.bValue}"); // 3, 30
            Console.WriteLine($"class_b: {aclass_b.aValue}, {aclass_b.bValue}"); // 3, 30
            Console.WriteLine();
        }
    }
}
// Exercises:
// 1.   In the console project you created in BOOP _01_10 remove the variable Name in class Stock
//      - Draw a memory address/memory cell diagram of the creation of the variable, myStock,  
// 2.   Assign myStock.Amount to 500. 
//      - Draw the memory address/memory cell diagram showing the change
