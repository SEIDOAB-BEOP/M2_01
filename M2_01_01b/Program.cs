using System;

namespace BOOP_01_01a
{
    namespace BOOP_01_01b
    {
        class Program
        {
            public static void PrintFromOtherNamespace()
            {
                Console.WriteLine("Hello World from namespace BOOP_01_01b");
            }
        }
    }
    namespace BOOP_01_01c
    {
        class Program
        {
            public static void PrintFromOtherNamespace()
            {
                Console.WriteLine("Hello World from namespace BOOP_01_01c");
            }
        }
    }
}

namespace BOOP_01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 12 * 30;        // Integer expression
            float f = 1.5F * 1.5F;  // Float expression

            Console.WriteLine(i);   // 360          
            Console.WriteLine(f);   // 2.25
            Console.WriteLine(Math.PI); // 3.141592...
            Console.WriteLine("Hello World"); // Hello World

            BOOP_01_01a.BOOP_01_01b.Program.PrintFromOtherNamespace();
            BOOP_01_01a.BOOP_01_01c.Program.PrintFromOtherNamespace();
        }
    }
}
