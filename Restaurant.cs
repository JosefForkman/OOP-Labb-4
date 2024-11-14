using OOP_Labb_4.utls;

public class Restaurant()
{
    public List<MenuItem> MenuItems { get; set; } = [];
    public Queue<Order> Orders { get; set; } = [];

    public void AddToMenu(MenuItem menuItem)
    {
        MenuItems.Add(menuItem);
        menuItem.ToString();
    }
    public void ShowMenu()
    {
        foreach (var item in MenuItems)
        {
            Console.WriteLine(item.ToString());
        }
    }
    public void CreateOrder(Order order)
    {
        Orders.Enqueue(order);

        Console.WriteLine("Order created:");
        order.ShowOrder();
        Console.WriteLine("We have received your order and will be at your table soon.");

    }

    public void HandleOrder()
    {
        if (Orders.Count == 0)
        {
            Console.WriteLine("No orders to handle.");
        }
        else
        {
            var order = Orders.Dequeue();
            order.ShowOrder();
        }
    }
    public void ShowOrders()
    {
        foreach (var order in Orders)
        {
            order.ShowOrder();
            HelpConsole.InnerDevider();
        }
    }
    public void ShowNextOrder()
    {
        var order = Orders.Peek();
        order.ShowOrder();
    }
    public void ShowOrderCount()
    {
        Console.WriteLine($"There are {Orders.Count} orders.");
    }
}
