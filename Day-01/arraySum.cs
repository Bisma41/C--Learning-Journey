using System;

namespace Array
{
    internal class program
    {
        static void Main(string[] args)
        {
            string[] ages = { "10", "20", "30", "40", "50" };
            for (int i = 0; i< ages.Length; i++)
            {
                Console.WriteLine(ages[i] + ages[i+1]);
            }
        }
    }
}
