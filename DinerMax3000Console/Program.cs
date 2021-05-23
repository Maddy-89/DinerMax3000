namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu summerMenu = new Menu();
            summerMenu.Name = "Summer menu";
            summerMenu.AddMenuItem("Salmon", "Garlic Butter Fresh Salmon", 25.50);
            summerMenu.AddMenuItem("Taco", "Salty Chips", 10);
        }
    }
}
