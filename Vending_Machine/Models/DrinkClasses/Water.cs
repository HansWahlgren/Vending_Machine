namespace Vending_Machine.Models.DrinkClasses
{
    public class Water : Drink
    {
        public Water(int productId) : base(productId)
        {
            base.Name = "Water";
            base.Price = 10;
            base.bottleSize = "33cl";
            base.calories = 50;
            base.warning = "";
        }
    }
}
