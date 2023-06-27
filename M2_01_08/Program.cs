using System;

namespace BOOP_01_08
{
    class Program
    {
        static void Main(string[] args)
        {

            int intVar1;
            short shortVar1;

            shortVar1 = short.MaxValue;
            intVar1 = shortVar1;            // implicit conversion OK
            Console.WriteLine(intVar1);     // 32767

            intVar1 = 35400;                // Outside short range
            shortVar1 = (short) intVar1;    // explicit conversion must be done
            Console.WriteLine(shortVar1);   // -30136 - caused by int 4 bytes while short 2 bytes

            intVar1 = short.MaxValue;       // Inside short range
            shortVar1 = (short)intVar1;     
            Console.WriteLine(shortVar1);   // 32767 OK as within short range
            Console.WriteLine();

            float floatVar1;
            double doubleVar1;

            floatVar1 = float.MaxValue;
            doubleVar1 = floatVar1;          // implicit conversion OK
            Console.WriteLine(doubleVar1);   //3,4028234663852886E+38  not exact the same d.o.p

            doubleVar1 = 7.4028235E+38D;     // outside float range
            floatVar1 = (float) doubleVar1;  // explict conversion must be done
            Console.WriteLine(floatVar1);    // 8 - wrong value cased by value larger than float range

            doubleVar1 = float.MaxValue;     // inside float range
            floatVar1 = (float)doubleVar1;   
            Console.WriteLine(floatVar1);    // 3,4028235E+38 OK as within float range
            Console.WriteLine();

            intVar1 = 100000001;        
            floatVar1 = intVar1;            // implict conversion ok but d.o.p will be lost
            Console.WriteLine(floatVar1);   // 100000000

            intVar1 = (int)floatVar1;       // explicit needed due to range difference        
            Console.WriteLine(intVar1);     // 100000000
        }
    }
}
// Exercises:
// 1.   Declare a variable of type long, longVar1, and assign it a value. Declare another variable of type int, intVar2,
//      and assign it the value of longVar1. Do you have to make an implicit or explicit type conversion?
// 2.   Declare a variable of byte, byteVar1 and assign it a value. Declare another variable of type int intVar3
//      and assign it the value of byteVar1. Do you have to make an implicit or explicit type conversion?
// 3.   Create a new console project. Declare variables of real types and make at least one implicit and one explicit conversion.
