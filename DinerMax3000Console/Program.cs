namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name = "Summer menu";
            summerMenu.AddMenuItem("Salmon", "Garlic Butter Fresh Salmon", 25.50);
            summerMenu.AddMenuItem("Taco", "Salty Chips", 10);
            summerMenu.HospitalDirections = "Right around the corner!";

            DrinkMenu outsideDrinks = new DrinkMenu();
            outsideDrinks.Disclaimer = "Do not drink and code.";
            outsideDrinks.AddMenuItem("Wine O", "red delicious", 10);
            outsideDrinks.AddMenuItem("Its Yellow?", "Salty and Sweet", 10);

            Order hungryGuestOrder = new Order();
            for (int x=0; x<=summerMenu.items.Count-1; x++)
            {
                MenuItem currentItem = summerMenu.items[x];
                hungryGuestOrder.items.Add(currentItem);
            }
            foreach(MenuItem currentItem in outsideDrinks.items)
            {
                hungryGuestOrder.items.Add(currentItem);
            }
        }
    }
}
