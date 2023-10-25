using Core;
using Selection.Easy;
using Selection.Medium;
using Selection.Hard;

namespace Selection
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
                //new Bigger() ,
                //new Rainbow() ,
                //new OddAndEven() ,
                //new Grader() ,
                //new Quiz() ,
                //new Sorter() ,
                //new Calculator() ,
                //new CheckSum() ,
                new Pangram()


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