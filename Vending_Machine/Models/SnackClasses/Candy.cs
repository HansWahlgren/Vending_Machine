namespace Vending_Machine.Models.SnackClasses
{
    public class Candy : Snack
    {
        public Candy(int productId) : base()
        {
            base.ProductId = productId;
            base.Name = "Mixed Candy bag";
            base.price = 30;
            base.bagSize = "150g";
            base.calories = 500;
            base.warning = "Contains Gelatin";
        }
    }
}
