namespace Vending_Machine.Models
{
    public class Snack : Product
    {
        protected string bagSize;

        public Snack(int productId)
        {
            base.ProductId = productId;
        }

        public override string ShowInfo()
        {
            return ($"Product Nr: {ProductId.ToString()}\n{Name}\nPrice: {Price.ToString()}kr\nSize: {bagSize}" +
                $"\nCalories: {calories.ToString()}\n{warning}");
        }

        public override string Consume()
        {
            return ("You quietly eat up everything in your bag of snacks");
        }
    }
}
