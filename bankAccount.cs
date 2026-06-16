// Problem Statement:

// You are developing a bank account management system. The program must manage different types of bank accounts and apply the correct fees or interest rates based on the account type:

//     Savings Account: Apply a 2% interest rate.

//     Checking Account: Apply a $10 monthly fee.

//     Business Account: Apply a 1% interest rate and a $20 monthly fee.

//     For all other account types, display an error message.

// Instructions:

// Write a switch case to handle different account types and apply the correct fees or interest rates. The program should prompt the user to enter the account type and the current balance, then calculate and display the new balance after applying the fees or interest.

Console.WriteLine("Please enter your account type (savings, checking, business):");
string accountType = Console.ReadLine().ToLower();
Console.WriteLine("Please enter your current balance:");
double balance = Convert.ToDouble(Console.ReadLine());
switch (accountType)
{
    case "savings":
        balance += balance * 0.02;
        Console.WriteLine("Your new balance after applying interest is: $" + balance);
        break;

    case "checking":
        balance -= 10;
        Console.WriteLine("Your new balance after applying fee is: $" + balance);
        break;

    case "business":
        balance += balance * 0.01;
        balance -= 20; 
        Console.WriteLine("Your new balance after applying interest and fee is: $" + balance);
        break;

    default:
        Console.WriteLine("Invalid account type entered.");
        break;
}