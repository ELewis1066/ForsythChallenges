using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection
{
    namespace Medium
    {
        public class Sorter : Problem
        {
            public override string Name => "Medium.Sorter";

            public Sorter() { }


            public override void Execute()
            {
                // get numbers and add to an array
                Console.Write("Enter a list of numbers e.i {1,4,2,8,3}: ");
                string[] inputedNumber = Console.ReadLine().Replace(" ", string.Empty).Split(",");

                // quick sort; or we could do a bubble, as it comes up very often in A-level
                Array.Sort(inputedNumber);

                // display each number
                foreach (string number  in inputedNumber)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
