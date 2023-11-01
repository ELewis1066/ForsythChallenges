using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    namespace Medium
    {
        public class Guesser : Problem
        {
            public override string Name => "Medium.Guesser";

            Random rng = new Random();

            public override void Execute()
            {
                bool isFound = false;
                uint counter = 0;

                int randomNumberGenerated = rng.Next(1, 101);
                Console.WriteLine("I have a number between 1-100");

                while (!isFound)
                {
                    Console.Write("What is your guess? ");
                    uint numberGuessed = Convert.ToUInt32(Console.ReadLine());

                    counter ++;
                    if (numberGuessed == randomNumberGenerated) 
                    {
                        Console.WriteLine($"Correct, you took {counter}");
                        isFound = true;
                    }
                    else if (numberGuessed > randomNumberGenerated) 
                    {
                        Console.WriteLine("Too high");
                    }
                    else if (numberGuessed < randomNumberGenerated)
                    {
                        Console.WriteLine("Too low");
                    }
                }
            }
        }
    }
}
