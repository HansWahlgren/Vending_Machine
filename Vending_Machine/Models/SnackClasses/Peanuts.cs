namespace Vending_Machine.Models.SnackClasses
{
    public class Peanuts : Snack
    {
        public Peanuts(int productId) : base()
        {
            base.ProductId = productId;
            base.Name = "Peanuts bag";
            base.price = 35;
            base.bagSize = "200g";
            base.calories = 500;
            base.warning = "Contains Peanuts";
        }
    }
}
