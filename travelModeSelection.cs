string mode;
Console.WriteLine("Please enter your mode of travel (bus, train, bike):");
mode = Console.ReadLine();

switch (mode.ToLower())
{
    case "bus":
        Console.WriteLine("booking a bus ticket.");
        break;
    case "train":
        Console.WriteLine("booking a train ticket.");
        break;
    case "bike":
        Console.WriteLine("booking a bike ticket.");
        break;
    default:
        Console.WriteLine("Invalid mode of travel selected.");
        break;
}