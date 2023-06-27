using System;

namespace BOOP_01_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Signed integrals example
            sbyte sbyteVar1 = 10;         // decimal
            sbyte sbyteVar2 = 0b00001010; // 10 in binary
            sbyte sbyteVar3 = 0x0A;       // 10 in hexadecimal

            Console.WriteLine("type sbyte");
            Console.WriteLine(sizeof(sbyte));  // 1 - 1 byte equals 8 bits  
            Console.WriteLine(sbyte.MaxValue); // 127 - using type data member MaxValue (a constant)
            Console.WriteLine(sbyte.MinValue); // -128
            Console.WriteLine(sbyteVar1);              //10
            Console.WriteLine(sbyteVar1 == sbyteVar2); // True
            Console.WriteLine(sbyteVar2 == sbyteVar3); // True

            int intVar1 = 350;
            int intVar2 = int.Parse("350");  // type function member Parse()

            Console.WriteLine();
            Console.WriteLine("type int");
            Console.WriteLine(sizeof(int));  // 4
            Console.WriteLine(int.MaxValue); // 2147483647
            Console.WriteLine(int.MinValue); // -2147483648
            Console.WriteLine(intVar1);      // 350
            Console.WriteLine(intVar1 == intVar2); // True

            //unsigned integrals example
            byte byteVar1 = 235;         // decimal

            Console.WriteLine();
            Console.WriteLine("type byte");
            Console.WriteLine(sizeof(byte));  // 1
            Console.WriteLine(byte.MaxValue); // 255
            Console.WriteLine(byte.MinValue); // 0
            Console.WriteLine(byteVar1);      // 235

            uint uintVar1 = 2_200_000_000U;   // using separator _ for better readability, U suffix
                            
            Console.WriteLine();
            Console.WriteLine("type uint");
            Console.WriteLine(sizeof(uint));  // 4
            Console.WriteLine(uint.MaxValue); // 4294967295
            Console.WriteLine(uint.MinValue); // 0
            Console.WriteLine(uintVar1);      // 2200000000
        }
    }
}
// Exercises:
// 1.   Step through above program with the debugger. Set a breakpoint on row 10 and single step.
//      Check in the debugger output window the values of the variables.
// 2.   Explain above what is a type, variable and value
// 3.   Do you understand why variables can have same value even though they are initialized differently.
// 4.   Modify above code to add a variable byteVar2 of type "byte" and initialize it with 235 binary. 
//      Binary converter at https://www.binaryhexconverter.com/decimal-to-binary-converter
//      Print out the variable byteVar2



