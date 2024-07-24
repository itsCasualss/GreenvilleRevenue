using System;

public class GreenvilleRevenuee : IAssignment 
{
    public void Run()
    {
        // Initialize variables for motto and ticket price
        const int ticketPrice = 25; 
        string motto = "The stars shine in Greenville.";

        // Display the motto
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

    // Method to display the motto
    static void DisplayMotto(string motto)
    {
        Console.WriteLine("\n");    
        Console.WriteLine("************************************");
        Console.WriteLine($"*  {motto}  *");
        Console.WriteLine("************************************");
    }

    // Method to display the menu options
    static void DisplayMenu()
    {
        Console.WriteLine("\nPlease Enter the following number below from the following menu:");
        Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
        Console.WriteLine("2. Exit");
    }

    // Method to calculate and display the revenue
    static void CalculateRevenue(int ticketPrice)
    {
        // Read user input for last year's and this year's contestants
        Console.WriteLine("\nEnter the number of contestants last year:");
        int lastYearContestants = int.Parse(Console.ReadLine());
        Console.WriteLine("\nEnter the number of contestants this year:");
        int thisYearContestants = int.Parse(Console.ReadLine());

        // Calculate expected revenue
        int revenue = thisYearContestants * ticketPrice;
        // Determine if this year's contestants are more than last year's
        bool isBigger = thisYearContestants > lastYearContestants;

        // Display results
        Console.WriteLine($"\n\nLast year's competition had {lastYearContestants} contestants, and this year's has {thisYearContestants} contestants.");
        Console.WriteLine($"Revenue expected this year is ${revenue:N0}");

        // Display appropriate message based on contestant comparison
        if (thisYearContestants > lastYearContestants * 2)
        {
            Console.WriteLine("The competition is more than twice as big this year!");
        }
        else if (thisYearContestants > lastYearContestants)
        {
            Console.WriteLine("\x1b[1mThe competition is bigger than ever!\x1b[0m");
        } // Added \x1b[1m __ \x1b[0m to make the text bold 
        else
        {
            Console.WriteLine("A tighter race this year! Come out and cast your vote!");
        }

        // Display the motto again
        DisplayMotto("The stars shine in Greenville.");
    }
}