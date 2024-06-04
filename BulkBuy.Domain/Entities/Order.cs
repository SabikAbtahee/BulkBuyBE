namespace BulkBuy.Domain.Entities
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

        public DateTimeOffset? PurchaseTime { get; set; }

        public DateTimeOffset? DeliveryStartTime { get; set; }

        public DateTimeOffset? DeliveryEndTime { get; set; }

        public DateTimeOffset? PickUpTime { get; set; }

        public DateTimeOffset? CancelletionTime { get; set; }

        public string Status { get; set; } // Can be a enum


    }
}
