using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordgåter
{
    class RiddleList
    {
        private List<Riddle> _riddles;
        public int Count => _riddles.Count;

        public RiddleList()
        {
            _riddles = new List<Riddle>();
        }

        public void Add(Riddle riddle)
        {
            _riddles.Add(riddle);
        }

        public void Show()
        {
            foreach (var riddle in _riddles)
            {
                riddle.Show();
            }
        }
    }
}
