using System;

namespace BOOP_01_11c
{
    class Program
    {
        struct bStruct { public int aValue; public int[] bArray; }
        static void Main(string[] args)
        {
            //Assignment Value Type (struct) containing value and reference type members
            bStruct bstruct_a = new bStruct { aValue = 1, bArray = new int[] { 1, 10 } };
            bStruct bstruct_b = new bStruct { aValue = 2, bArray = new int[] { 2, 20 } };

            bstruct_b = bstruct_a;
            bstruct_a.aValue = 3;
            bstruct_a.bArray = new int[] { 3, 30 };

            Console.WriteLine($"bstruct_a: {bstruct_a.aValue}, {{{bstruct_a.bArray[0]}, {bstruct_a.bArray[1]}}}"); // 3, {3, 30}
            Console.WriteLine($"bstruct_b: {bstruct_b.aValue}, {{{bstruct_b.bArray[0]}, {bstruct_b.bArray[1]}}}"); // 1, {1, 10}
            Console.WriteLine();
        }
    }
}
