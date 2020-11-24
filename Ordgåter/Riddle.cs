using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordgåter
{
    class Riddle
    {
        private Word _firstWord;
        private Word _secondWord;
        private int _commonLength;

        public Riddle(Word firstWord, Word secondWord, int commonLength)
        {
            _commonLength = commonLength;
            _firstWord = firstWord;
            _secondWord = secondWord;
        }

        public override string ToString()
        {
            return _firstWord.HideLastPart(_commonLength) 
                   + " " 
                   + _secondWord.HideFirstPart(_commonLength);
        }

        public bool IsCorrect(Guess guess)
        {
            //return guess.GetFirstWord() == _firstWord.WordAsString;
            return true;
        }

        public void Show()
        {
            Console.WriteLine(this);
        }
    }
}
