using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;

namespace Ordgåter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Velge tilfeldig ord.  - eks: abonnement
            var wordList = new WordList();
            var riddleFactory = new RiddleFactory(wordList);
            var riddleList = riddleFactory.CreateList(200);
            riddleList.Show();
        }
    }
}