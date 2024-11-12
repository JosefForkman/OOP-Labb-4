public class MenuItem(int id, string name, decimal price)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public decimal Price { get; set; } = price;

    public override string ToString()
    {
        return $"{Name} - {Price:C}";
    }
}
