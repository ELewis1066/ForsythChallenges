using Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Selection
{
    namespace Medium
    {
        public class Quiz : Problem
        {
            public override string Name => "Medium.Quiz";

            static Dictionary<string, string> quiz = new Dictionary<string, string>
            {
                { "What is the first colour of the rainbow?", "red" },
                { "What is 68/4?", "17"},
                { "Who is the current UK leader of the opposition?", "kier starmer" }
             };

            public Quiz() { }

            public override void Execute()
            {
                int correct = 0;
                var timer = new Stopwatch();
                timer.Start();

                foreach (var item in quiz)
                {
                    Console.WriteLine(item.Key);
                    string answer = Console.ReadLine();
                    if (!string.IsNullOrEmpty(answer) && answer.ToLower() == item.Value.ToLower())
                    {

                        Console.WriteLine("Correct Well done");
                        correct++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect unlucky");
                    }
                }

                timer.Stop();
                TimeSpan timeTaken = timer.Elapsed;
                Console.WriteLine($"You got {correct}/3 question right in {timeTaken.TotalSeconds.ToString("F1")} seconds ");
            }

        }
    }
    
}
