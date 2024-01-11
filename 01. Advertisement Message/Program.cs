namespace _01.Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new[] { "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can't live without this product." };

            string[] events = new[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

            string[] authors = new[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = new[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int numberOfMessages = int.Parse(Console.ReadLine());

            Random random = new Random();

            for (int i = 0; i < numberOfMessages; i++)
            {
                string phrase = phrases[random.Next(phrases.Length)];
                string result = events[random.Next(events.Length)];
                string author = authors[random.Next(authors.Length)];
                string city = cities[random.Next(cities.Length)];
                Console.WriteLine($"{phrase} {result} {author} – {city}.");
            }
        }
    }
}