using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    namespace Easy
    {
        public class Times : Problem
        {
            public override string Name => "Easy.Times";

            const uint NUMBER_OF_ITERATIONS = 13;
            const uint FIVE_TIMES_TABLE = 5;
            public override void Execute()
            {
                Console.WriteLine("Please press enter to display the 5 times table");
                Console.ReadLine();

                for (int i = 1; i < NUMBER_OF_ITERATIONS; i++)
                {
                    Console.WriteLine($"{FIVE_TIMES_TABLE} x {i} = {FIVE_TIMES_TABLE * i} ");
                }
            }
        }
    }
}
