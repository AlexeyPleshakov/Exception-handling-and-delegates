using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Sorter
    {
        public event EventHandler<List<string>> SortingTriggered;

        public void PerformSorting(int option, List<string> surnames)
        {

            if (option == 1)
            {
                surnames.Sort();
            }
            else if (option == 2)
            {
                surnames.Sort();
                surnames.Reverse();
            }
            else
            {
                throw new SortingException("Некорректное значение для сортировки.");
            }

            SortingTriggered?.Invoke(this, surnames);
        }
    }
}
