using System;

class TicketPriceCalculator
{
    static void Main()
    {
        // Prompt the user to enter their age
        Console.Write("Please enter your age: ");
        string? input = Console.ReadLine();

        // Check if input is null or empty
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
            return;
        }

        // Convert the input to an integer
        if (int.TryParse(input, out int age))
        {
            // Calculate the ticket price based on age
            int ticketPrice = CalculateTicketPrice(age);

            // Display the ticket price
            Console.WriteLine($"The ticket price for age {age} is: GHC{ticketPrice}");
        }
        else
        {
            // Display an error message for invalid input
            Console.WriteLine("Invalid input. Please enter a valid numerical age.");
        }

        // Prevent console from closing immediately
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static int CalculateTicketPrice(int age)
    {
        // Determine the ticket price based on the age
        if (age <= 12 || age >= 65)
        {
            return 7;
        }
        else
        {
            return 10;
        }
    }
}
