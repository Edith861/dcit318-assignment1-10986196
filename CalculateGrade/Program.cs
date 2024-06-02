using System;

class GradeCalculator
{
    static void Main()
    {
        // Prompt the user to enter a numerical grade
        Console.WriteLine("Enter a numerical grade (0-100): ");
        string? input = Console.ReadLine();

        // Debug output to check if input is received
        Console.WriteLine($"Debug: Received input: {input}");

        // Check if input is null
        if (input == null)
        {
            Console.WriteLine("Input cannot be null. Please enter a valid numerical grade.");
            return;
        }

        // Convert the input to an integer
        int grade;
        bool isNumeric = int.TryParse(input, out grade);

        // Debug output to check if input conversion is successful
        Console.WriteLine($"Debug: Conversion successful: {isNumeric}, Grade: {grade}");

        // Validate the input
        if (isNumeric && grade >= 0 && grade <= 100)
        {
            // Determine the letter grade
            string letterGrade = GetLetterGrade(grade);
            // Display the corresponding letter grade
            Console.WriteLine($"The letter grade for {grade} is: {letterGrade}");
        }
        else
        {
            // Display an error message for invalid input
            Console.WriteLine("Invalid input. Please enter a numerical grade between 0 and 100.");
        }

        // Prevent console from closing immediately
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static string GetLetterGrade(int grade)
    {
        // Determine the letter grade based on the numerical grade
        if (grade >= 90)
        {
            return "A";
        }
        else if (grade >= 80)
        {
            return "B";
        }
        else if (grade >= 70)
        {
            return "C";
        }
        else if (grade >= 60)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }
}
