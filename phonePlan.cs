int dataNeeds;
Console.WriteLine("How much data do you need (in GB)?");
dataNeeds = Convert.ToInt32(Console.ReadLine());
bool wantsInternationalCalls;
Console.WriteLine("Do you want international calls? (yes/no)");
wantsInternationalCalls = Console.ReadLine().ToLower() == "yes";

switch (dataNeeds)
{
    case 2:
        Console.WriteLine("You are choosing the Basic Plan");
        break;

    case 5:
        Console.WriteLine("You are choosing the Standard Plan");
        break;

    case 10:
        if (wantsInternationalCalls)
        {
            Console.WriteLine("You are choosing the Premium Plan with International Calling");
        }
        else
        {
            Console.WriteLine("You are choosing the Standard Plan");
        }
        break;

    case -1:
        Console.WriteLine("You are choosing the Unlimited Plan with International Calling");
        break;

    default:
        Console.WriteLine("Invalid data request");
        break;
}