// 

using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        greetUser(name);

    }

    public static void greetUser(string userName)
    {
        Console.WriteLine("Hello, " + userName + "! Welcome to the program.");
    }
}
