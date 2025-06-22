namespace Basics
{
    internal class Person
    {
        public string Name;
        public int Age;

        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, {Age} years old.");
        }
    }
}
