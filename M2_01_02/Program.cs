using System;

namespace BOOP_01_02
{
    class Program
    {
        static int Main(string[] args)
        {
            int i = 12 * 30;        // Integer expression
            float f = 1.5F * 1.5F;  // Float expression

            Console.WriteLine(i);   // 360          
            Console.WriteLine(f);   // 2.25
            Console.WriteLine(Math.PI); // 3.141592...

            Console.WriteLine(args.Length); //0

            if (args.Length > 0)
            {
                Console.WriteLine("Hello " + args[0]);
                return 0;
            }
            else
            {
                Console.WriteLine("No command line parameters");
                return 1;
            }
        }
    }
}
