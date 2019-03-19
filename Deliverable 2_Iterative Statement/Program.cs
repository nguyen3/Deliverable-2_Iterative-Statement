/*
 Author: Trang Nguyen
 Date: 1/17/2019
 Comment: This C# Console application demonstrates 
          the use of iterative statement from 1 to 100
*/

using System;

namespace Deliverable_2_Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for input
            Console.WriteLine("Enter an Integer value between 1 and 100 to execute an iterative statement: ");

            //Use try-catch to validate the user input
            try
            {
                //Gather the input
                string input = Console.ReadLine();

                //Assign input as an integer
                int value_of_input = int.Parse(input);

                //Execute For Loop
                for (int i = 0; i < value_of_input; i++)
                {
                    Console.WriteLine("You have entered " + value_of_input.ToString() + ". This is the current integer value in the loop: " + i.ToString());
                }
                Console.WriteLine("Press any key to exit the program...");
                //Read key to exit the program
                Console.ReadKey(true); 
            }//End of try

            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again...");
                Console.WriteLine("Press any key to exit the program...");
                //Read key to exit the program
                Console.ReadKey(true);
            }//End of catch
        }//End of Main
    }//End of class
}//End of namespace
