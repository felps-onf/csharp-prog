int number;

do
{
    Console.WriteLine("Please enter a number:");
    number = Convert.ToInt32(Console.ReadLine());

    if (number % 2 == 0)
    {
        Console.WriteLine("The number is even.");
        break;
    }
    else
    {
        Console.WriteLine("The number is odd.");
    }

} while (number > 0  && number <= 10);  