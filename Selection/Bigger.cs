using Core;

namespace Selection
{
    namespace Easy
    {
        public class Bigger : Problem
        {
            public override string Name => "Easy.Bigger";

            public Bigger() { }


            public override void Execute()
            {
                // get the numbers
                Console.Write("Enter first number: ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the second number: ");
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                // see which one is bigger and which is smaller
                int biggerNumber = Math.Max(firstNumber, secondNumber);
                int smallerNumber = Math.Min(firstNumber, secondNumber);

                // see if they are the same
                if ( biggerNumber == smallerNumber )
                {
                    Console.WriteLine($"{biggerNumber} is the same as the {smallerNumber}");
                }
                else
                {
                    Console.WriteLine($"{biggerNumber} is bigger than {smallerNumber}");
                }
            }
        }
    }
    
}
