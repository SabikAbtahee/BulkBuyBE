using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBuy.Entities.Entity
{
    public class OrderBatch : BaseEntity
    {
        public List<string> OrderIds { get; set; }

        public string ProductId { get; set; }

        public string Status { get; set; } // can be a enum

        public DateTime CreationDateTime { get; set; }

        public DateTime CompletionDateTime { get; set; }

        public DateTime? DeliveryStartTime { get; set; }

        public DateTime? DeliveryEndTime { get; set; }

    }
}
