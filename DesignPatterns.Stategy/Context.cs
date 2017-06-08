using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    class SortedList
    {
        private List<string> _list = new List<string>();
        private SortStrategy _sortStategy;

        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            this._sortStategy = sortStrategy;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            _sortStategy.Sort(_list);

            foreach (string name in _list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }
}
