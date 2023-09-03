using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.App
{
    public record API
    {
        private readonly List<int> _silverPricesByDay;

        public API()
        {
            _silverPricesByDay = new List<int>() { 2, 4, 1, 3, 9, 0, 4, 3 };
        }

        public API(List<int> silverPricesByDays)
        {
            _silverPricesByDay = silverPricesByDays;
        }

        public int GetNumOfDays()
        {
            return _silverPricesByDay.Count;
        }

        public int GetPriceOfDay(int day)
        {
            return _silverPricesByDay[day];
        }
    }
}
