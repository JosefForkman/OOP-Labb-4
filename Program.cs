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
            var calzone = new MenuItem(1, "Calzone", 110.35M);
            var vegetariana = new MenuItem(2, "Vegetariana", 115);
            var mexicana = new MenuItem(3, "Mexicana", 2.50M);
            var te = new MenuItem(4, "Te", 3.50M);

            restaurant.AddToMenu(calzone);
            restaurant.AddToMenu(vegetariana);
            restaurant.AddToMenu(mexicana);
            restaurant.AddToMenu(te);

            HelpConsole.Devider(3);
            restaurant.ShowMenu();

            HelpConsole.Devider(4);
            var orderOne = new Order([calzone, mexicana], 1);
            var orderTwo = new Order([calzone, vegetariana], 2);
            var orderThree = new Order([mexicana, te], 3);

            restaurant.CreateOrder(orderOne);
            Console.WriteLine();
            restaurant.CreateOrder(orderTwo);
            Console.WriteLine();
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
            var orderFour = new Order([mexicana, te], 4);
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