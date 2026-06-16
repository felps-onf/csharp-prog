
float income;
float taxRate;
float taxAmount;
bool resident;

Console.WriteLine("Enter your income:");
income = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("You are resident? (yes/no)");
resident = Console.ReadLine().ToLower() == "yes";


float CalculateTax(float income, bool resident)
{
    float taxRate;
    if (income < 50000)
    {
        if (resident)
        {
            taxRate = 0.10f;
        }
        else
        {
            taxRate = 0.15f;
        }
    }
    else if (income >= 50000 && income < 100000)
    {
        if (resident)
        {
            taxRate = 0.2f;
        }
        else
        {
            taxRate = 0.25f;
        }
    }
    else
    {
        if (resident)
        {
            taxRate = 0.3f;
        }
        else
        {
            taxRate = 0.35f;
        }
    }
    return income * taxRate;
}

taxAmount = CalculateTax(income, resident);
Console.WriteLine("Your tax amount is: " + taxAmount);


