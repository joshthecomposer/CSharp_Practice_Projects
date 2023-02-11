Wine wine1 = new Wine("Pinot Noir", 200, "California", 1995);
Wine wine2 = new Wine("Chardonnay", 210, "Italy", 2022);
Soda soda1 = new Soda("Coke", 350, false);
Soda soda2 = new Soda("Diet Pepsi", 0, true);
Coffee coffee1 = new Coffee("Latte", 150, "Dark");

List<Drink> drinkList = new List<Drink>{wine1, wine2, soda1, soda2, coffee1};

foreach (Drink d in drinkList)
{
    d.ShowDrink();
}