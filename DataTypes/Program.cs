using DataTypes.Easy;
using DataTypes.Medium;
using DataTypes.Hard;

namespace DataTypes
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
                new Greeter() ,
                new Printer() ,
                new Divider() ,
                new StoryTeller() ,
                new Speedy() ,
                new BMI() ,
                new Validator() ,
                new SpeedRacer() ,
                new Graduater()

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