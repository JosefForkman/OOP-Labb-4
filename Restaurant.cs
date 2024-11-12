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
