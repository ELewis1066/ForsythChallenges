using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    namespace Easy
    {
        public class Password : Problem
        {
            public override string Name => "Easy.Password";

            public override void Execute()
            {
                // flag for the while loop
                bool isConfirmedPassword = false;
                
                Console.Write("Enter your new password: ");
                string firstInput = Console.ReadLine();


                while (!isConfirmedPassword)
                {
                    Console.Write("Confirm new password: ");
                    string conformativeInput = Console.ReadLine();

                    if (conformativeInput == firstInput)
                    {
                        Console.WriteLine("Password confirmed.");
                        isConfirmedPassword = true;
                    }
                    else 
                    {
                        Console.WriteLine("Passwords do not match, please try again");
                    }
                }
            }
        }
    }
}
