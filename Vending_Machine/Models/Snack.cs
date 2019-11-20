namespace Vending_Machine.Models
{
    public class Snack : Product
    {
        protected string bagSize;
        public Snack() : base()
        {
            bagSize = "0 g";
        }

        public override string ShowInfo()
        {
            return ($"Product Id: {ProductId.ToString()}\n{Name}\nPrice: {price.ToString()}kr\nSize: {bagSize}" +
                $"\nCalories: {calories.ToString()}\n{warning}");
        }

        public override string Consume()
        {
            return ("You quietly eat up everything in your bag of snacks");
        }
    }
}
