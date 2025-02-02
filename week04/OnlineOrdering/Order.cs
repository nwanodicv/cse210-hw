using System;
using System.Collections.Generic;

namespace OnlineOrdering
{
    public class Order
    {
        private List<OrderItem> _items;
        private string _customerName;
        private string _address;

        public Order(string customerName, string address)
        {
            _customerName = customerName;
            _address = address;
            _items = new List<OrderItem>();
        }

        public void AddItem(OrderItem item)
        {
            _items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            _items.Remove(item);
        }

        public decimal GetTotalPrice()
        {
            decimal total = 0;
            foreach (var item in _items)
            {
                total += item.Price * item.Quantity;
            }
            return total;
        }

        public void PrintOrder()
        {
            Console.WriteLine($"Order for {_customerName}");
            Console.WriteLine($"Shipping to: {_address}");
            Console.WriteLine("Items:");
            foreach (var item in _items)
            {
                Console.WriteLine($"{item.Name} - {item.Quantity} x {item.Price:C}");
            }
            Console.WriteLine($"Total: {GetTotalPrice():C}");
        }
    }

    public class OrderItem
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        public OrderItem(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Order order = new Order("John Doe", "123 Main St");
    //        order.AddItem(new OrderItem("Laptop", 999.99m, 1));
    //        order.AddItem(new OrderItem("Mouse", 19.99m, 2));
    //        order.PrintOrder();
    //    }
    //}
}