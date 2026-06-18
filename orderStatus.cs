string [] orderStatus = { "Processing", "Shipped", "Delivered", "Cancelled" };

for (int i = 0; i < orderStatus.Length; i++)
{
    switch (orderStatus[i])
    {
        case "Processing":
            Console.WriteLine("Your order is being processed.");
            break;
        case "Shipped":
            Console.WriteLine("Your order has been shipped.");
            break;
        case "Delivered":
            Console.WriteLine("Your order has been delivered.");
            break;
        case "Cancelled":
            Console.WriteLine("Your order has been cancelled.");
            break;
        default:
            Console.WriteLine("Invalid order status.");
            break;
    }
}