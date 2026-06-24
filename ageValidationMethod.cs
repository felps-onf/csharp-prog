// 

using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());
        if (IsValidAge(age))
        {
            Console.WriteLine("You are eligible."); 
    }
        else
        {
            Console.WriteLine("You are not eligible.");
        }
    }


    public static bool IsValidAge(int age)
    {
        return age >= 18;
    }
}