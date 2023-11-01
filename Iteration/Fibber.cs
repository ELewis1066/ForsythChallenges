using Core;

namespace Iteration
{
    namespace Easy
    {
        public class Fibber : Problem
        {
            public override string Name => "Easy.Fibber";

            public override void Execute()
            {
                Console.Write("How many terms of the Fibonacci series would you like? ");
                uint numberOfIterations = Convert.ToUInt32(Console.ReadLine());

                // terms in which the fibonacci sequences is based upon
                uint a = 0;
                uint b = 1;
                uint c;

                // stated in problem; the series is to start with 0,1
                // just in case the user was to enter 1 term or 2 terms
                // if statement is used
                if (numberOfIterations == 2) 
                {
                    Console.Write($"{a}");
                    Console.Write($",{b}");
                }
                else if (numberOfIterations == 1) 
                {
                    Console.Write($"{a}");
                }
                else
                {
                    Console.Write($"{a}");
                    Console.Write($",{b}");

                    for (int i = 2; i < numberOfIterations; i++)
                    {
                        c = a + b;
                        a = b;
                        b = c;

                        Console.Write($",{b}");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
