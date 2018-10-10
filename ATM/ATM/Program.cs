using System;

namespace ATM
{
    public class Program
    {
        public static double balance = 0;//user balance

        static void Main()
        {
            string menu = "1 - View Balance\n2 - Withdraw\n3 - Deposit\n4 - Exit\n";
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
                    //Validate user choice
                    menuController = ValidateChoice(userSelection);
                }
                catch
                {
                    Console.WriteLine("\nInvalid Choice. Please select from the following menu:");
                    continue;
                }

                //If menuController == -1, reprompt
                if(menuController == -1)
                {
                    Console.WriteLine("\nMenu option not recognized. Please select again:");
                    continue;
                }

                //If choice is exit, exit
                if (menuController == 4)
                {
                    Console.WriteLine("\n\nThank you for banking with us. Goodbye!\n\n");
                    return;
                }

                //If choice is withdraw or add, get amount
                if(menuController == 2 || menuController == 3)
                {
                    string action = menuController == 2 ? "withdraw" : "deposit";
                    Console.WriteLine($"\n\nPlease enter amount to {action}");
                    amount = Convert.ToDouble(Console.ReadLine());
                }

                //Execute user choice
                switch(menuController)
                {
                    case 1:
                        ViewBalance();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
            }
        }

        //Validates user menu choice and returns the selection as an int
        public static int ValidateChoice(string input)
        {
            //Console.WriteLine("validateChoice called");
            int convertedInput;
            //Try to convert input to int
            try
            {
                convertedInput = Convert.ToInt32(input);
            }
            //Catch error, throw to main, and return with status of -1
            catch(Exception e)
            {
                throw e;
            }
            //Finally, verify that the number is 1-4 and return with status of 0, else return -1
            finally
            {
                convertedInput = Convert.ToInt32(input);
            }
            if (convertedInput > 0 && convertedInput < 5) return convertedInput;
            else return -1;
        }

        //Displays the balance
        public static void ViewBalance()
        {
            Console.WriteLine($"Current balance: ${balance}\n\n");
        }

        //Checks that withdrawal is possible, then withdraws amount chosen
        //returns 0 for success, -1 for error
        int Withdrawn()
        {
            return 0;
        }

        //Adds chosen amount to user balance. Returns 0 is successful, -1 if error
        int Add()
        {
            return 0;
        }

        //Displays exit message
        void ExitMessage()
        {
        }
    }
}
