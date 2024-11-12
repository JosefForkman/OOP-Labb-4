namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var pancakes = new MenuItem(1, "pancakes", 15.50M);
            var te = new MenuItem(2, "TE", 1.50M);
            var egg = new MenuItem(3, "egg", 2.50M);

            var restaurant = new Restaurant();
            restaurant.AddToMenu(pancakes);
            restaurant.AddToMenu(te);
            restaurant.AddToMenu(egg);

            restaurant.ShowMenu();
        }
    }
}