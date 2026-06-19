double circleArea(double radius)
{
    return Math.PI * Math.Pow(radius, 2);
}

Console.WriteLine("Enter the radius of the circle:");
double radius = Convert.ToDouble(Console.ReadLine());
double area = circleArea(radius);
Console.WriteLine($"The area of the circle is: {area}");
