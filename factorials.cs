int number = 8;

int factorial = 1;
while (number > 0)
{
    Console.WriteLine("Current number: " + number);
    factorial *= number;
    number--;
}
Console.WriteLine("The factorial is: " + factorial);
