namespace basic
{
    internal class Product
    {
        public string Name;
        public double Price;
        public Product(string n, double p)
        {
            Name = n;
            Price = p;
        }
        public void Show()
        {
            Console.WriteLine($"{Name} \t -> Rs. {Price}");
        }
    }
}
