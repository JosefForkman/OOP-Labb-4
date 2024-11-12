public class Restaurant(List<MenuItem> menuItems, Queue<Order>? orders = null)
{
    public List<MenuItem> MenuItems { get; set; } = menuItems;
    public Queue<Order> Orders { get; set; } = orders ?? new Queue<Order>();

    public void AddToMenu(MenuItem menuItem)
    {

    }
    public void ShowMenu()
    {

    }
    public void CreateOrder(Order order)
    {
        var newOrder = Orders.Prepend(order);

        Console.WriteLine($"The new order:\n id: {order}");
    }

    public void HandleOrder()
    {

    }
    public void ShowOrders()
    {

    }
    private void ShowNextOrder()
    {

    }
    public void ShowOrderCount()
    {

    }
}
