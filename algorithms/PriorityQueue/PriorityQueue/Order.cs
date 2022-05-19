using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue.Core
{
    public class Order
    {
        public int Id { get; set; }
        public Guid PublicKey { get; set; } = Guid.NewGuid();
        public string? Name { get; set; }
        public string? Importance { get; set; } = OrderImportances.NotImportant;
    }

    public static class OrderImportances
    {
        public const string Important = nameof(Important);
        public const string NotImportant = nameof(NotImportant);
    }
}
