namespace Vending_Machine.Models
{
    public class Food : Product
    {
        protected string foodSize;

        public Food(int productId)
        {
            base.ProductId = productId;
        }

        public override string ShowInfo()
        {
            return ($"\tProduct Nr: {ProductId.ToString()}\n\t{Name}\n\tPrice: {Price.ToString()}kr\n\tSize: {foodSize}" +
                $"\n\tCalories: {calories.ToString()}\n\t{warning}");
        }

        public override string Consume()
        {
            return ("With great hunger you devour your meal fast");
        }
    }
}
