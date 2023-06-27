using System;

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

// Exercises:
// 1.   Change the Command Line Parameter by changing Project->Debug->Application Argument.
// 2.   Run the program with and without parameters and see the difference in output. 
//          - Where do you think the decision if there are parameters or not happen?
// 3.   Run the program from command line with and without parameters