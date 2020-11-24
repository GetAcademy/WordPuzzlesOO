using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordgåter
{
    class Word
    {
        public string WordAsString { get; }

        public Word(string word)
        {
            WordAsString = word;
        }

        public string HideLastPart(int length)
        {
            var firstPart = WordAsString.Substring(0, WordAsString.Length - length);
            var lastPart = string.Empty.PadLeft(length, '_');
            return firstPart + lastPart;
        }

        public string HideFirstPart(int length)
        {
            var lastPart = WordAsString.Substring(WordAsString.Length - length);
            var firstPart = string.Empty.PadLeft(length, '_');
            return firstPart + lastPart;
        }

        public bool StartsWith(string firstPart)
        {
            return WordAsString.StartsWith(firstPart);
        }

        public string GetLastPart(int length)
        {
            return WordAsString.Substring(WordAsString.Length - length);
        }
    }
}
