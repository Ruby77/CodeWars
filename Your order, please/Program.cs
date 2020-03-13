using System.Linq;

namespace Your_order__please
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static string Order(string words)
        {
            var allWords = words.Split(' ').ToList();
            string[] wordList = new string[allWords.Count];

            allWords.ForEach(t =>
            {
                t.ToList().ForEach(c =>
                {
                    if (int.TryParse(c.ToString(), out int result))
                    {
                        wordList[result - 1] = t;
                    }
                });
            });

            return string.Join(" ", wordList);
        }
    }
}
