using OOP_Labb_4.utls;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // 01
            var restaurant = new Restaurant();

            // 02
            var pancakes = new MenuItem(1, "pancakes", 15.50M);
            var te = new MenuItem(2, "TE", 1.50M);
            var egg = new MenuItem(3, "egg", 2.50M);
            var bacon = new MenuItem(4, "bacon", 3.50M);

            restaurant.AddToMenu(pancakes);
            restaurant.AddToMenu(te);
            restaurant.AddToMenu(egg);
            restaurant.AddToMenu(bacon);

            HelpConsole.Devider(3);
            restaurant.ShowMenu();

            HelpConsole.Devider(4);
            var orderOne = new Order([pancakes, te, egg, bacon], 1);
            var orderTwo = new Order([te, egg], 2);
            var orderThree = new Order([bacon, pancakes], 3);

            restaurant.CreateOrder(orderOne);
            restaurant.CreateOrder(orderTwo);
            restaurant.CreateOrder(orderThree);

            HelpConsole.Devider(5);
            Console.WriteLine("Show orders:");
            restaurant.ShowOrders();

            HelpConsole.Devider(6);
            restaurant.ShowOrderCount();

            HelpConsole.Devider(7);
            Console.WriteLine("Next order:");
            restaurant.ShowNextOrder();

            HelpConsole.Devider(8);
            Console.WriteLine("Order handled:");
            restaurant.HandleOrder();

            HelpConsole.Devider(9);
            restaurant.ShowOrderCount();

            HelpConsole.Devider(10);
            var orderFour = new Order([egg, pancakes], 4);
            restaurant.CreateOrder(orderFour);

            HelpConsole.Devider(11);
            restaurant.ShowOrderCount();

            HelpConsole.Devider(12);
            Console.WriteLine("Order handled:");
            restaurant.HandleOrder();
            HelpConsole.InnerDevider();
            Console.WriteLine("Order handled:");
            restaurant.HandleOrder();

            HelpConsole.Devider(13);
            restaurant.ShowOrderCount();

            HelpConsole.Devider(14);
            Console.WriteLine("Next order:");
            restaurant.ShowNextOrder();

            HelpConsole.Devider(15);
            Console.WriteLine("Order handled:");
            restaurant.HandleOrder();

            HelpConsole.Devider(16);
            restaurant.ShowOrderCount();
        }
    }
}