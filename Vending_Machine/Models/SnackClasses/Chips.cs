namespace Vending_Machine.Models.SnackClasses
{
    public class Chips : Snack
    {
        public Chips(int productId)
        {
            base.ProductId = productId;
            base.Name = "Chips bag";
            base.price = 25;
            base.bagSize = "100g";
            base.calories = 600;
            base.warning = "";
        }
    }
}
