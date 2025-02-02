using System;


namespace OnlineOrdering;
class Program
{
    static void Main(string[] args)
    {
        Order order = new Order("John Doe", "123 Main St");
        order.AddItem(new OrderItem("Laptop", 999.99m, 1));
        order.AddItem(new OrderItem("Mouse", 19.99m, 2));
        order.PrintOrder();
    }
}