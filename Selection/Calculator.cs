using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Selection
{
    namespace Hard
    {

        public class Calculator : Problem
        {
            public override string Name => "Hard.Calculator";
            
            public Calculator() { }

            // random generator
            static private Random rng = new Random();

            public Dictionary<string, Func<int, int, int>> operators = new Dictionary<string, Func<int, int, int>>
            {
                // lamda calculation, high API, reduces the need to right out
                // specified function for each simple calculation
                { "+", (x,y) => x + y },
                { "-", (x,y) => x - y },
                { "*", (x,y) => x * y },
                { "/", (x,y) => x / y },
                { "^", (x,y) => (int) Math.Pow(x,y) },
            };
           
            // generates a random number between 2,50 (51, because it is exclusive)
            int GenerateNextRandomValue()
            {
                int rn = rng.Next(2, 51);
                return rn;
            }

            public override void Execute()
            {
                // get the two random numbers
                int first = GenerateNextRandomValue();
                int second = GenerateNextRandomValue();

                // convert the keys to the an array, and picks a random sign 
                // because of it
                string op = operators.Keys.ToArray()[rng.Next(operators.Keys.Count)];

                // when you get the random operator, use the key
                // to find which value it opens, therefore finding the answer
                // for the calculation
                Func<int, int, int> fn = operators[op];
                int expected = fn(first, second);
                
                Console.WriteLine($"What is {first} {op} {second}?"); 
                int answer = Convert.ToInt32(Console.ReadLine());

                // checks whether or not the users input is correct :D
                if ( answer == expected)
                {
                    Console.WriteLine("correct, well done");
                }
                else
                {
                    Console.WriteLine("incorrect, unlucky");
                }
            }
        }
        
    }
}
