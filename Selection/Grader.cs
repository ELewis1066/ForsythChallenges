using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Selection
{
    namespace Medium
    {
        public class Grader : Problem
        {
            public override string Name => "Medium.Grader";

            public Grader() { }

            public override void Execute()
            {
                Console.Write("Enter your mark (out of 100): ");
                int markInput = Convert.ToInt32(Console.ReadLine());

                string grade;
                int marksNeededForNextGrade = 0;

                switch (markInput)
                {
                    case int m when (m >= 80 && m <= 100):
                        grade = "A*";
                        marksNeededForNextGrade = 0;
                        break;
                    case int m when (m >= 70 && m <= 79):
                        grade = "A";
                        marksNeededForNextGrade = 80 - m;
                        break;
                    case int m when (m >= 60 && m <= 69):
                        grade = "B";
                        marksNeededForNextGrade = 70 - m;
                        break;
                    case int m when (m >= 50 && m <= 59):
                        grade = "C";
                        marksNeededForNextGrade = 60 - m;
                        break;
                    case int m when (m >= 40 && m <= 49):
                        grade = "D";
                        marksNeededForNextGrade = 50 - m;
                        break;
                    case int m when (m >= 30 && m <= 39):
                        grade = "E";
                        marksNeededForNextGrade = 40 - m;
                        break;
                    case int m when (m >= 0 && m <= 29):
                        grade = "U";
                        marksNeededForNextGrade = 30 - m;
                        break;
                    default:
                        grade = "Invalid input";
                        break;
                }

                Console.WriteLine($"Grade {grade}");
                // if not invalid output or at the top grade; tell student how many marks to next grade. 
                if (grade != "Invalid input" && marksNeededForNextGrade > 0)
                {
                    Console.WriteLine($"Marks needed for the next grade: {marksNeededForNextGrade}");
                }
            }
        }
    }
}
