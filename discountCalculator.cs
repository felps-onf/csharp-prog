using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the original price:");
        double originalPrice = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the discount percentage:");
        double discountPercentage = Convert.ToDouble(Console.ReadLine());

        double discountedPrice = CalculateDiscountedPrice(originalPrice, discountPercentage);
        Console.WriteLine("The discounted price is: " + discountedPrice);
    }

    static double CalculateDiscountedPrice(double price, double discount)
    {
        return price - (price * (discount / 100));
    }   
}