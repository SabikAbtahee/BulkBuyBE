namespace BulkBuy.Domain.Entities
{
    public class Location : BaseEntity
    {
        public string Area { get; set; }
        public string Description { get; set; }
        public bool IsAvailable { get; set; }

        // may give coordinates 
    }
}
