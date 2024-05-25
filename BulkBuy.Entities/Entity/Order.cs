using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBuy.Entities.Entity
{
    public class Order : BaseEntity
    {
        public string PersonId { get; set; }

        public string ProductId { get; set; }

        public string OrderBatchId { get; set; }

        public string OrderId { get; set; } // a unique generated string that will be used to identify order

        public string TransactionId { get; set; }

        public int TotalCost { get; set; }

        public int TotalUnitAmount { get; set; }

        public DateTime? PurchaseTime { get; set; }

        public DateTime? DeliveryStartTime { get; set; }

        public DateTime? DeliveryEndTime { get; set; }

        public DateTime? PickUpTime { get; set; }

        public DateTime? CancelletionTime { get; set; }

        public string Status { get; set; } // Can be a enum

        
    }
}
