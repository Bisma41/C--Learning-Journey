namespace basic
{
    internal class Movie
    {
        public string Title { get; private set; }
        public int Rating { get; private set; }
        public string Genre { get; private set; }

        public Movie(string v1, int v2, string v3)
        {
            this.Title = v1;
            this.Rating = v2;
            this.Genre = v3;
        }

        public void IsRecommended()
        {
            if (Rating > 7)
                Console.WriteLine($"Recommended");
            else
                Console.WriteLine($"Not Recommended"); ;
        }
    }
}
