using System;

namespace Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            string[] phrase = { "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product." };

            string[] event1 = { "Now I feel good.", "I have succeeded with this product.", 
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!"};

            string[] author = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            
            string[] city = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            for (int i = 0; i < n; i++)
            {
                string phraseRnd = Randomizer(phrase);
                string eventRnd = Randomizer(event1);
                string authorRnd = Randomizer(author);
                string cityRnd = Randomizer(city);

                Console.WriteLine($"{phraseRnd} {eventRnd} {authorRnd} – {cityRnd}");
            }
        }

        static string Randomizer(string[] phrase)
        {
            Random rnd = new Random();
            int randomPosition = rnd.Next(0, phrase.Length-1);
            string result = phrase[randomPosition];
            return result;
        }
    }
}
