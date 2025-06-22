namespace BasicUtilities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car S1 = new Car();
            S1.Make = "Toyota";
            S1.model = "Corolla";
            S1.year = 2018;
            S1.DisplayInfo();

        }
    }
}
