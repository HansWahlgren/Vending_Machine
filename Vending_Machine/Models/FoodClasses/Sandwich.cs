namespace Vending_Machine.Models.FoodClasses
{
    public class Sandwich : Food
    {
        public Sandwich(int productId) : base()
        {
            base.ProductId = productId;
            base.Name = "Sandwich";
            base.price = 30;
            base.foodSize = "50g";
            base.calories = 250;
            base.warning = "Gluten";
        }
    }
}
