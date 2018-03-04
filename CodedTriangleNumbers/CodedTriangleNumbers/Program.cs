using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedTriangleNumbers
{
    public class WordCounter
    {
        private readonly Dictionary<char, int> values = new Dictionary<char, int>
        {
            {'A', 1 },
            {'B', 2 },
            {'C', 3 },
            {'D', 4 },
            {'E', 5 },
            {'F', 6 },
            {'G', 7 },
            {'H', 8 },
            {'I', 9 },
            {'J', 10 },
            {'K', 11 },
            {'L', 12 },
            {'M', 13 },
            {'N', 14 },
            {'O', 15 },
            {'P', 16 },
            {'Q', 17 },
            {'R', 18 },
            {'S', 19 },
            {'T', 20 },
            {'U', 21 },
            {'V', 22 },
            {'W', 23 },
            {'X', 24 },
            {'Y', 25 },
            {'Z', 26 }
        };

        private string ReadFile(string filename)
        {
            return File.OpenText(filename).ReadToEnd();
        }

        public bool IsWordValueTriangleNumber(string word)
        {
            return IsTriangleNumber(word.Sum(c => values.First(item => item.Key == c).Value));
        }

        public bool IsTriangleNumber(int sum)
        {
            return Math.Abs(((Math.Sqrt(8 * sum + 1) - 1) / 2) % 1) <= (Double.Epsilon * 100);
        }

        internal int Count()
        {
            string text = ReadFile("words.txt");
            List<string> words = GetWordList(text);
            return words.Count(word => IsWordValueTriangleNumber(word));
        }

        private static List<string> GetWordList(string text)
        {
            List<string> words = new List<string>();
            string tempWord = String.Empty;
            foreach (var item in text)
            {
                if (char.IsLetter(item))
                    tempWord += item;
                else if (!String.IsNullOrEmpty(tempWord))
                {
                    words.Add(tempWord);
                    tempWord = String.Empty;
                }

            }
            return words;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WordCounter wordCounter = new WordCounter();
            Console.WriteLine(wordCounter.Count()); 
        }
    }
}
