int age;
Console.WriteLine("Please enter your age:");
age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter your membership type (basic/premium):");
string membershipType = Console.ReadLine();


void CalculateMembershipFee(int age, string membershipType)
{
    int fee;
    if (age < 18)
    {
        if (membershipType == "basic")
        {
            fee = 15;
        }
        else
        {
            fee = 25;
        }
        Console.WriteLine("You are eligible for a youth membership. Your fee is: $" + fee);
    }

    else if (age >= 18 && age < 60)

    {
        if (membershipType == "basic")
        {
            fee = 30;
        }
        else
        {
            fee = 50;
        }
        Console.WriteLine("You are eligible for an adult membership. Your fee is: $" + fee);

    }

    else
    {
        if (membershipType == "basic")
        {
            fee = 20;
        }
        else
        {
            fee = 35;
        }
        Console.WriteLine("You are eligible for a senior membership. Your fee is: $" + fee);
    }
}

CalculateMembershipFee(age, membershipType);


