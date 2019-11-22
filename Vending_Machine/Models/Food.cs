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
            return ($"Product Nr: {ProductId.ToString()}\n{Name}\nPrice: {Price.ToString()}kr\nSize: {foodSize}" +
                $"\nCalories: {calories.ToString()}\n{warning}");
        }

        public override string Consume()
        {
            return ("With great hunger you devour your meal fast");
        }
    }
}
