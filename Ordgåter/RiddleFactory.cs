using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordgåter
{
    class RiddleFactory
    {
        private WordList _wordList;

        // kremOST OSTekake 3
        // lakrisPIPE PIPElort 4
        //private int[] _commonLengths = { 3, 4, 5 };
        private int _commonLength = 3;

        public RiddleFactory(WordList wordList)
        {
            _wordList = wordList;
        }

        public RiddleList CreateList(int count)
        {
            var riddleList = new RiddleList();
            while(riddleList.Count < count)
            {
                var riddle = Create();
                if (riddle != null) riddleList.Add(riddle);
            }
            return riddleList;
        }

        private Riddle Create()
        {
            var firstWord = _wordList.GetRandomWord();
            var lastPartOfFirstWord = firstWord.GetLastPart(_commonLength);
            var secondWord = _wordList.GetWordStartingWith(lastPartOfFirstWord);
            if (secondWord == null) return null;
            var commonWord = firstWord.GetLastPart(_commonLength);
            if (!_wordList.Contains(commonWord)) return null;
            return new Riddle(firstWord, secondWord, _commonLength);
        }
    }
}
