using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        // Prompt the user to enter the sides of the triangle
        Console.Write("Enter the length of side 1: ");
        string? input1 = Console.ReadLine();
        Console.Write("Enter the length of side 2: ");
        string? input2 = Console.ReadLine();
        Console.Write("Enter the length of side 3: ");
        string? input3 = Console.ReadLine();

        // Convert the inputs to integers
        if (int.TryParse(input1, out int side1) && int.TryParse(input2, out int side2) && int.TryParse(input3, out int side3))
        {
            // Determine the type of the triangle
            string triangleType = DetermineTriangleType(side1, side2, side3);

            // Display the type of the triangle
            Console.WriteLine($"The triangle is {triangleType}.");
        }
        else
        {
            // Display an error message for invalid input
            Console.WriteLine("Invalid input. Please enter valid numerical lengths for the sides.");
        }

        // Prevent console from closing immediately
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static string DetermineTriangleType(int side1, int side2, int side3)
    {
        // Check for equilateral triangle
        if (side1 == side2 && side2 == side3)
        {
            return "Equilateral";
        }
        // Check for isosceles triangle
        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            return "Isosceles";
        }
        // Otherwise, it's a scalene triangle
        else
        {
            return "Scalene";
        }
    }
}

