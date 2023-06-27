using System;

namespace BOOP_01_11d
{
    class Program
    {
        class bClass { public int aValue; public int[] bArray; }
        static void Main(string[] args)
        {
            //Assignment Reference Type (class) containing value and reference type members
            bClass bclass_a = new bClass { aValue = 1, bArray = new int[] { 1, 10 } };
            bClass bclass_b = new bClass { aValue = 2, bArray = new int[] { 2, 20 } };

            bclass_b = bclass_a;
            bclass_a.aValue = 3;
            bclass_a.bArray = new int[] { 3, 30 };

            Console.WriteLine($"bstruct_a: {bclass_a.aValue}, {{{bclass_a.bArray[0]}, {bclass_a.bArray[1]}}}"); // 3, {3, 30}
            Console.WriteLine($"bstruct_b: {bclass_b.aValue}, {{{bclass_b.bArray[0]}, {bclass_b.bArray[1]}}}"); // 3, {3, 30}
            Console.WriteLine();
        }
    }
}
