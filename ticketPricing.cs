int age;
Console.WriteLine("Please enter your age:");
age = Convert.ToInt32(Console.ReadLine());

if (age < 12)
{
    Console.WriteLine("Half price ticket");
}
else if (age >= 12 && age < 65)
{
    Console.WriteLine("Full price ticket");
}
else
{
    Console.WriteLine("Senior discount ticket");
}
