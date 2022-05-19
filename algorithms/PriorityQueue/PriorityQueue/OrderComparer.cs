using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue.Core
{
    public class OrderComparer : IComparer<string>
    {
        public int Compare(string orderAImportance, string orderBImportance)
        {
            var orderAIsImportant = orderAImportance!.Equals(OrderImportances.Important, StringComparison.InvariantCultureIgnoreCase);
            var orderBIsImportant = orderBImportance!.Equals(OrderImportances.Important, StringComparison.InvariantCultureIgnoreCase);

            if (orderAIsImportant == orderBIsImportant)
            {
                return 0;
            }
            else if (orderAIsImportant)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
