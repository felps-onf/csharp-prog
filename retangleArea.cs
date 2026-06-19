double RetangleArea(double width, double height)
{
    return width * height;
}

Console.WriteLine("Enter the width of the rectangle:");
double width = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the height of the rectangle:");
double height = Convert.ToDouble(Console.ReadLine());
double area = RetangleArea(width, height);
Console.WriteLine($"The area of the rectangle is: {area}");
