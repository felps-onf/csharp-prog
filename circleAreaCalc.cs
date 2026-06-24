using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the radius of the circle:");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = CalculateCircleArea(radius);
        Console.WriteLine("The area of the circle is: " + area);
    }

    static double CalculateCircleArea(double r)
    {
        return Math.PI * r * r;
    }
}
