namespace Vending_Machine.Models
{
    public abstract class Product
    {
        protected int price;
        protected int calories;
        protected string warning;
        public int ProductId { get; protected set; }
        public string Name { get; protected set; }

        public Product()
        {
            ProductId = 0;
            price = 0;
            calories = 0;
            warning = "None";
            Name = "No product avaliable";
        }

        public abstract string ShowInfo();

        public abstract string Consume();
    }
}