using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    namespace Medium
    {
        public class StoryTeller : Problem
        {
            public override string Name => "Medium.StoryTeller";
            public StoryTeller() { }

            const int AGE_OF_GRADUATION = 18;

            public override void Execute()
            {
                // questions asked for story
                Console.Write("Enter your name? ");
                string name = Console.ReadLine();

                Console.Write("What is your age? ");
                uint age = Convert.ToUInt32(Console.ReadLine());

                Console.Write("What is your/parents job? ");
                string job = Console.ReadLine();

                Console.Write("What is your favourite coulour? ");
                string favouriteColour = Console.ReadLine();

                Console.Write("Which animal scares you the most? ");
                string fearedAnimal = Console.ReadLine();

                // completed story of each age group
                if (age > AGE_OF_GRADUATION)
                {
                    uint yearsAfterGraduation = age - AGE_OF_GRADUATION;
                    string storyForOldPeople = @$"{name} graduated {yearsAfterGraduation} years ago and moved into a new house with a bright {favouriteColour} front door.
He loved the house but was plagued by {fearedAnimal} in his back garden so he bought a robotic scarecrow to frighten them away. 
He paid for this by saving up his income from his job as a {job} but his wife was very angry as she wanted new carpets instead.";
                    Console.WriteLine(storyForOldPeople);
                }
                else
                {
                    uint yearsUntilGraduation = AGE_OF_GRADUATION - age;
                    string storyForYoungPeople = @$"{name} will graduate in {yearsUntilGraduation} years. And lives with his parents and sibiligs with a noticable {favouriteColour} front door.
He loves his house but it was plagued by {fearedAnimal} in his back garden. So with a big smile he laughed and hid in his room watching anime. 
His parents paided an ancient monk to deal with the infestation, with there job as a {job}, but {name} didnt care he continued to watch anime";
                    Console.WriteLine(storyForYoungPeople);
                }

                
            }
        }
    }
    
}
