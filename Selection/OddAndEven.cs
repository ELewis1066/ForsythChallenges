using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection
{
    namespace Easy
    {
        public class OddAndEven : Problem
        {
            public override string Name => "Easy.OddAndEven";

            public OddAndEven() { }

            static int HighestCommonFactor(int a, int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }

            // Function to calculate the Lowest Common Multiple (LCM)
            static int LowestCommonMultiple(int a, int b)
            {
                int gcd = HighestCommonFactor(a, b);
                int lcm = (Math.Abs(a) / gcd) * b;
                return lcm;
            }



            // sees if the modulo of 2 is 0 then its even, if not then its odd
            string HowManyOddOrEven(int firstNumber, int secondNumber)
            {
                // reduces the need to calcaulte every time
                bool isFirstEven = firstNumber % 2 == 0;
                bool isSecondEven = secondNumber % 2 == 0;

                // function to find and return 
                if (isFirstEven && isSecondEven)
                {
                    return "Both numbers are even";
                }
                if (!isFirstEven && !isSecondEven)
                {
                    return "Both numbers are odd";
                }
                else 
                {
                    return "One is even and the other is odd";
                }
            }

            public override void Execute()
            {
                // get inputs
                Console.Write("Enter first number: ");
                int firstInput = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number: ");
                int secondInput = Convert.ToInt32(Console.ReadLine());

                // call and pass parameters
                Console.WriteLine(HowManyOddOrEven(firstInput, secondInput));

                // LCM extention
                int findLowestCommonMulitple = LowestCommonMultiple(firstInput, secondInput);
                Console.WriteLine($"The lowest common multiple is {findLowestCommonMulitple}");
            }
        }
    }
}

