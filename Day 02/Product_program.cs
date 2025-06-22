namespace BasicUtilities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] P1 = new Product[5];
            P1[0] = new Product("Soap", 100);
            P1[1] = new Product("Comb", 250);
            P1[2] = new Product("Coffee", 1000);
            P1[3] = new Product("Tea", 120);
            P1[4] = new Product("Cup", 150);
            for (int i=0; i < P1.Length; i++)
            {
                P1[i].Show();
            }
            
        }
    }
}
