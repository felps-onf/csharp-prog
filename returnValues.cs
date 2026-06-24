// Step 3: Using Methods with Return Values
// Create a method that returns a value. This method should calculate the sum of two numbers and return the result.

// Instructions:

// Define a method CalculateSum that takes two integer parameters and returns their sum.

// Call the method passing two numbers and print the result.


using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = CalculateSum(num1, num2);
        Console.WriteLine("The sum is: " + sum);
    }

    static int CalculateSum(int a, int b)
    {
        return a + b;
    }
}
