using System;

namespace BOOP_01_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //constant declarations
            const int intConstant = 500;
            const float floatConstant = 500.50F;
            const string stringConstant = "Hello World";

            //various variable declarations, with and without initialization
            int intVariable1;               // unintialized
            int intVariable2 = intConstant; // init at declaration
            int intVariable3 = int.MaxValue;

            float floatVariable1, floatVariable2, floatVariable3; // Multiple uninitialized

            string stringVariable1;
            string stringVariable2 = stringConstant; // assigning using constant
            string stringVariable3 = "Hello Martin"; // assigning using literal

            bool boolVariable1 = false, boolVariable2, boolVariable3; // Mix uninitialized and initialized

            //variable assignments, i.e. assing a variable a value (an instance of a type)
            intVariable1 = intVariable2 * 3; // expression using variable and a literal
            
            floatVariable1 = floatVariable2 = 2.6F * floatConstant; //multiple assignment same value
            floatVariable3 = float.MinValue;

            stringVariable1 = "Say Again: " + stringConstant; // string concatination

            boolVariable2 = !boolVariable1; // bool expression negating a bool variable
            boolVariable3 = intVariable1 > intVariable3; // bool expression comparing two int variables 

            //Let's print out the constants and variables     
            Console.WriteLine(intConstant);  // 500
            Console.WriteLine(intVariable1); // 1500
            Console.WriteLine(intVariable2); // 500
            Console.WriteLine(intVariable3); // 2147483647

            Console.WriteLine();
            Console.WriteLine(floatConstant);  // 500.50
            Console.WriteLine(floatVariable1); // 1301.2999
            Console.WriteLine(floatVariable2); // 1301.2999
            Console.WriteLine(floatVariable3); // -3.4028235E+38

            Console.WriteLine();
            Console.WriteLine(stringConstant);  // Hello World
            Console.WriteLine(stringVariable1); // Say Again: Hello World
            Console.WriteLine(stringVariable2); // Hello World
            Console.WriteLine(stringVariable3); // Hello Martin

            Console.WriteLine();
            Console.WriteLine(boolVariable1); // False
            Console.WriteLine(boolVariable2); // True
            Console.WriteLine(boolVariable3); // False
        }
    }
}

// Exercises:
// 1.   Create a new Console Project (Exercise0105) and its corresponding GitHub repository
// 2.   In the project write a simple program that declares an integer constant of value 1234, an integer variable named twiceVal.
//      Assign twiceVal to 2 times the constant and print out the result, i.e., 2468.
// 3.   In the same program, declare two string constants "Hello " and "OOP1 class!". Declare a string variable and
//      assign it "Hello Newton OOP1 class!" using the two constants. 
// 4.   In the same program declare two float variables. Assign the first variable 5 and the
//      second variable to the first varaible + the previously declared integer constant.  
// 5.   Explain what is a type, value, variable and constans in your code.