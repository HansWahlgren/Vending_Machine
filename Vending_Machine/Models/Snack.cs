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
            return ($"\tProduct Nr: {ProductId.ToString()}\n\t{Name}\n\tPrice: {Price.ToString()}kr\n\tSize: {bagSize}" +
                $"\n\tCalories: {calories.ToString()}\n\t{warning}");
        }

        public override string Consume()
        {
            return ("You quietly eat up everything in your bag of snacks");
        }
    }
}
