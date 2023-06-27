using System;

namespace BOOP_01_11a
{
    class Program
    {
        struct aStruct { public int aValue; public int bValue; }
        static void Main(string[] args)
        {
            //Assignment Value Type (int)
            int int_a = 1;
            int int_b = 2;

            int_b = int_a;
            int_a = 3;

            Console.WriteLine($"int_a: {int_a}"); // 3
            Console.WriteLine($"int_b: {int_b}"); // 1
            Console.WriteLine();

            //Assignment Value Type (struct)
            aStruct astruct_a = new aStruct { aValue = 1, bValue = 10 };
            aStruct astruct_b = new aStruct { aValue = 2, bValue = 20 };

            astruct_b = astruct_a;
            astruct_a.aValue = 3;
            astruct_a.bValue = 30;

            Console.WriteLine($"struct_a: {astruct_a.aValue}, {astruct_a.bValue}"); // 3, 30
            Console.WriteLine($"struct_b: {astruct_b.aValue}, {astruct_b.bValue}"); // 1, 10
            Console.WriteLine();
        }
    }
}
// Exercises:
// 1.   In the console project you created in BOOP _01_09 remove the variable Name in struct Stock
//      - Draw a memory address/memory cell diagram of the creation of the variable, myStock,  
// 2.   Assign myStock.Amount to 500. 
//      - Draw the memory address/memory cell diagram showing the change
