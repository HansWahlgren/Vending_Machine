namespace Vending_Machine.Models
{
    public class Food : Product
    {
        protected string foodSize;

        public Food() : base()
        {
            foodSize = "0 g";
        }

        public override string ShowInfo()
        {
            return ($"Product Id: {ProductId.ToString()}\n{Name}\nPrice: {price.ToString()}kr\nSize: {foodSize}" +
                $"\nCalories: {calories.ToString()}\n{warning}");
        }

        public override string Consume()
        {
            return ("With great hunger you devour your meal fast");
        }
    }
}
