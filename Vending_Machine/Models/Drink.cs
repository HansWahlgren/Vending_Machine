namespace Vending_Machine.Models
{
    public class Drink : Product
    {
        protected string bottleSize;

        public Drink(int productId)
        {
            base.ProductId = productId;
        }

        public override string ShowInfo()
        {
            return ($"Product Nr: {ProductId.ToString()}\n{Name}\nPrice: {Price.ToString()}kr\nSize: {bottleSize}" +
                $"\nCalories: {calories.ToString()}\n{warning}");
        }

        public override string Consume()
        {
            return ("You quickly drink up the cold refreshing bottle");
        }
    }
}
