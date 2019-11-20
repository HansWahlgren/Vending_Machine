namespace Vending_Machine.Models.FoodClasses
{
    public class Burger : Food
    {
        public Burger(int productId) : base()
        {
            base.ProductId = productId;
            base.Name = "Hamburger";
            base.price = 40;
            base.foodSize = "80g";
            base.calories = 500;
            base.warning = "Contains meat, Gluten";
        }
    }
}
