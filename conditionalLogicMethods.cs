// 


using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsEven(number))
        {
            Console.WriteLine(number + " is an even number.");
        }
        else
        {
            Console.WriteLine(number + " is an odd number.");
        }
    }

    public static bool IsEven(int num)
    {
        return num % 2 == 0;
    }
}