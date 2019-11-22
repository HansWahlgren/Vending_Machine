namespace Vending_Machine.Models.FoodClasses
{
    public class Burger : Food
    {
        public Burger(int productId) : base(productId)
        {
            base.Name = "Hamburger";
            base.Price = 40;
            base.foodSize = "80g";
            base.calories = 500;
            base.warning = "Contains meat, Gluten";
        }
    }
}
