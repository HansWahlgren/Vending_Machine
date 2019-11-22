namespace Vending_Machine.Models
{
    public abstract class Product
    {
        protected int calories;
        protected string warning;
        public int ProductId { get; protected set; }
        public string Name { get; protected set; }
        public int Price { get; protected set; }


        public abstract string ShowInfo();

        public abstract string Consume();
    }
}