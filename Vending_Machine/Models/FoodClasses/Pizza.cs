namespace Vending_Machine.Models.FoodClasses
{
    public class Pizza : Food
    {
        public Pizza(int productId) : base(productId)
        {
            base.Name = "Pizza";
            base.Price = 35;
            base.foodSize = "70g";
            base.calories = 450;
            base.warning = "Contains meat, Gluten";
        }
    }
}
