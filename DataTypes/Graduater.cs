using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    namespace Hard
    {
        internal class Graduater : Problem
        {
            public override string Name => "Hard.Graduater";

            public Graduater() { }

            const int AGE_OF_GRADUATION = 21;
            const int MONTH_OF_GRADUATION = 6;
            const int DAY_OF_GRADUATION = 30;
            public override void Execute()
            {
                // Todays current date ( not including time )
                DateTime todayDate = DateTime.Today;

                // recives input on date of birth
                Console.Write("Enter you date of birth { dd/MM/yyyy }: ");
                string input = Console.ReadLine();

                //checks if it is formatted correctly
                if (DateTime.TryParseExact(input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime birthDay))
                {
                    Console.WriteLine($"(Assuming todays date is {todayDate.ToString("dd/MM/yyyy")})");
                    
                    // calculate difference in years
                    TimeSpan result = todayDate.Subtract(birthDay);
                    int differenceInDays = (int)(result.TotalDays / 365);
                    int differenceInYears = AGE_OF_GRADUATION - differenceInDays;

                    // check if they have already graduated
                    if (differenceInYears < 0)
                    {
                        int whenGraduated = differenceInDays - AGE_OF_GRADUATION;
                        Console.WriteLine($"You graduated {whenGraduated.ToString("F0")} years ago");
                    }
                    else
                    {
                        // add the new year of graduation to create the year at which a person graduates
                        DateTime newdateYear = todayDate.AddYears(differenceInYears);
                        DateTime dateOfGraduation = new DateTime(newdateYear.Year, MONTH_OF_GRADUATION, DAY_OF_GRADUATION);

                        // calculate the difference in days
                        TimeSpan differenceOfDates = dateOfGraduation - todayDate;
                        int daysLeft = differenceOfDates.Days;
                        Console.WriteLine($"You will graduate in {daysLeft} days.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid date format. Please enter a date in the format dd/MM/yyyy.");
                }

            }
        }
    }
}
