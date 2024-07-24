using System;

public class GreenvilleRevenue : IAssignment 
{
    public void Run()
    {
        //Initialize variables for motto and ticket price.
        const int ticketPrice = 25; 
        string motto = "The stars shine in Greenville.";

        // Displays motto 
        DisplayMotto(motto);

            // Main loop to show menu and get user input
            bool exit = false;
            while (!exit)
              {
                DisplayMenu();
                ConsoleKeyInfo choice = Console.ReadKey(intercept: true); // Read key without displaying it
                switch (choice.KeyChar)
                        
                    {
                        case '1':
                            Console.WriteLine("1");
                            CalculateRevenue(ticketPrice);
                            break;
                        case '2':
                            Console.WriteLine("2");
                            Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("\nInvalid choice. Please enter 1 or 2.");
                            break;
                    }
                }
    }


    
            static void DisplayMotto(string motto) //Method to display motto
            {
                Console.WriteLine("\n");    
                Console.WriteLine("************************************");
                Console.WriteLine($"*  {motto}  *");
                Console.WriteLine("************************************");
            }

            static void DisplayMenu() //method to display menue and options 
            {
                Console.WriteLine("\nPlease Enter the following number below from the following menu:");
                Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
                Console.WriteLine("2. Exit");
            }

    

            static void CalculateRevenue(int ticketPrice) //Method to calculate and display revenue
            {

                //Reads user input and converts to integer
                Console.WriteLine("\nEnter the number of contestants last year:");
                int lastYearContestants = int.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter the number of contestants this year:");
                int thisYearContestants = int.Parse(Console.ReadLine()); 

                int revenue = thisYearContestants * ticketPrice; //calculates expected revenue based on this years contestants
                bool isBigger = thisYearContestants > lastYearContestants; //compares the two years to see which is greater than 

                Console.WriteLine($"\n\nLast year's competition had {lastYearContestants} contestants, and this year's has {thisYearContestants} contestants.");
                Console.WriteLine($"Revenue expected this year is ${revenue:N0}");         
                Console.WriteLine($"It is {(isBigger ? "true" : "false")} that this year's competition is bigger than last year's.");
                //prints all the above defined results

                DisplayMotto("The stars shine in Greenville."); //display motto again
            }
        }
 