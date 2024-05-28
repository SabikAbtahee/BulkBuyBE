using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBuy.Core.Entities
{
    public class OrderBatch : BaseEntity
    {
        public List<string> OrderIds { get; set; }

        public string ProductId { get; set; }

        public string Status { get; set; } // can be a enum

        public DateTimeOffset CreationDateTime { get; set; }

        public DateTimeOffset CompletionDateTime { get; set; }

        public DateTimeOffset? DeliveryStartTime { get; set; }

        public DateTimeOffset? DeliveryEndTime { get; set; }

    }
}
