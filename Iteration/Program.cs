using Core;

using Iteration.Easy;
using Iteration.Medium;
using Iteration.Hard;

namespace Iteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This actually creates an instance of each problem,
            // not meant to be a sophisticated OO solution, just
            // allows easy run-through of problems.
            List<Problem> problems = new List<Problem>
            {
                new Times() , 
                new Fibber() , 
                new Password() ,
                new Guesser() ,
                new Caeser() ,
                ///
                ///
                ///
                new Coins()
            };

            // Run each problem.
            foreach (var problem in problems)
            {
                Console.WriteLine(problem.Name);
                problem.Execute();
            }
        }
    }
}