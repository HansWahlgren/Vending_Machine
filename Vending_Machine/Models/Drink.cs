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
            return ($"\tProduct Nr: {ProductId.ToString()}\n\t{Name}\n\tPrice: {Price.ToString()}kr\n\tSize: {bottleSize}" +
                $"\n\tCalories: {calories.ToString()}\n\t{warning}");
        }

        public override string Consume()
        {
            return ("You quickly drink up the cold refreshing bottle");
        }
    }
}
