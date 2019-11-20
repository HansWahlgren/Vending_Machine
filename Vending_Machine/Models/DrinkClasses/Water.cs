namespace Vending_Machine.Models.DrinkClasses
{
    public class Water : Drink
    {
        public Water(int productId) : base()
        {
            base.ProductId = productId;
            base.Name = "Water";
            base.price = 10;
            base.bottleSize = "33cl";
            base.calories = 50;
            base.warning = "";
        }
    }
}
