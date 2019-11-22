namespace Vending_Machine.Models.SnackClasses
{
    public class Chips : Snack
    {
        public Chips(int productId) : base(productId)
        {
            base.Name = "Chips bag";
            base.Price = 25;
            base.bagSize = "100g";
            base.calories = 600;
            base.warning = "";
        }
    }
}
