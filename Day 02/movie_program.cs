namespace BasicUtilities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie M1 = new Movie("Damsel", 8, "Adventure");
            Console.WriteLine($"Movie: {M1.Title} \n Genre: {M1.Genre} \n Rating: {M1.Rating}");
            M1.IsRecommended();
        }
    }
}
