using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBuy.Core.Entities
{
    public class Transaction : BaseEntity
    {
        public string OrderId { get; set; }
        public string PersonId { get; set; }
        public int Amount { get; set; }
        public string Status { get; set; } //enum
        public DateTimeOffset TransationTime { get; set; }
        // can also set transation type, location etc
    }
}
