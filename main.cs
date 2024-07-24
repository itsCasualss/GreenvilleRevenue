using System;


class Program
{
    static void Main(string[] args)
    {
        // Instantiate the specific assignment you want to run

        IAssignment assignment = new GreenvilleRevenuev01(); // Change this to which assignment program as needed

        // Run the selected assignment
        assignment.Run();
    }
}