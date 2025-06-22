namespace basic
{
    internal class Car
    {
        public String Make;
        public int year;
        public String model;

        public void DisplayInfo()
        {
            Console.WriteLine(year + "\t" + Make + "\t" + model);
        }
    }
}
