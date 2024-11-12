namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");
            var menuItems = new List<MenuItem>
            {
                new MenuItem(1, "packas", 15.50M),
                new MenuItem(2, "TE", 1.50M),
            };
            var restaurant = new Restaurant(menuItems);

            var order = new Order(menuItems.FindAll(item => item.Id == 1), 1);
            restaurant.CreateOrder(order);
        }
    }
}