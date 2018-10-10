using System;

namespace ATM
{
    public class Program
    {
        public static double balance = 0;//user balance
        static void Main()
        {
            string menu = "1 - View Balance/n2 - Withdraw\n3 - Deposit\n4 - Exit";
            string userSelection; //captures user menu choice
            int menuController;
            double amount; //captures user amount to withdraw or deposit

            //Welcome user
            Console.WriteLine("Welcome to Online Banking. Please select from the following menu (1, 2, 3, 4):");

            while (true)
            {
                //Show menu
                Console.WriteLine(menu);
                //Get user choice (try, catch error thrown from ValidateChoice and reprompt)
                userSelection = Console.ReadLine();
                try
                {
                    menuController = ValidateChoice(userSelection);
                }
                catch(Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                    Console.WriteLine("Invalid selection. Please select from the following menu:");
                    Console.WriteLine(menu);
                }
                //Validate user choice
                //If choice is exit, exit
                //If choice is withdraw or add, get amount
                //Execute user choice
            }
        }

        //Validates user menu choice and returns the selection as an int
        int ValidateChoice(string input)
        {
            //Try to convert input to int
            //Catch error, throw to main, and return with status of -1
            //Finally, return with status of 0
        }

        //Displays the balance and returns 0 for success, -1 for error
        int ViewBalance()
        {
        }

        //Checks that withdrawal is possible, then withdraws amount chosen
        //returns 0 for success, -1 for error
        int Withdrawn()
        {
        }

        //Adds chosen amount to user balance. Returns 0 is successful, -1 if error
        int Add()
        {
        }

        //Displays exit message
        void ExitMessage()
        {
        }
    }
}
