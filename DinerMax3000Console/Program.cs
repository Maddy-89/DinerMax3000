namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu summerMenu = new Menu();
            summerMenu.Name = "Summer menu";
            MenuItem salmon = new MenuItem();
            salmon.Title = "Salmon";
            salmon.Description = "Fresh Fish";
            salmon.Price = 25.50;
            summerMenu.items.Add(salmon);
        }
    }
}
