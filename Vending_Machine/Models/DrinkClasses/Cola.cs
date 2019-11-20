namespace Vending_Machine.Models.DrinkClasses
{
    public class Cola : Drink
    {
        public Cola(int productId) : base()
        {
            base.ProductId = productId;
            base.Name = "Coca Cola";
            base.price = 22;
            base.bottleSize = "50cl";
            base.calories = 400;
            base.warning = "Contains carbonic acid";
        }
    }
}
