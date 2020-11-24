using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordgåter
{
    class WordList
    {
        private static readonly Random Random = new Random();
        private Word[] _words;

        public WordList()
        {
            var lastWord = string.Empty;
            var filePath = "ordliste.txt";
            var wordList = new List<string>();
            foreach (var line in File.ReadLines(filePath, Encoding.UTF8))
            {
                var parts = line.Split('\t');
                var word = parts[1];
                if (word != lastWord
                    && word.Length > 6
                    && word.Length < 10
                    && !word.Contains("-"))
                {
                    wordList.Add(word);
                }
                lastWord = word;
            }
            _words = wordList.Select(s=>new Word(s)).ToArray();
        }

        public Word GetRandomWord()
        {
            var randomWordIndex = Random.Next(_words.Length);
            return _words[randomWordIndex];
        }

        public Word GetWordStartingWith(string firstPart)
        {
            // return _words.FirstOrDefault(word => word.StartsWith(firstPart));
            foreach (var word in _words)
            {
                if (word.StartsWith(firstPart)) return word;
            }
            return null;
        }

        public bool Contains(string commonWord)
        {
            foreach (var w in _words)
            {
                if (w.WordAsString == commonWord) return true;
            }

            return false;
        }
    }
}
