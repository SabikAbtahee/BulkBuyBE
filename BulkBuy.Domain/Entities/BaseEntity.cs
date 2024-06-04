using BulkBuy.Domain.Interfaces;
namespace BulkBuy.Domain.Entities
{
    public class BaseEntity : IBaseEntity
    {

        public BaseEntity()
        {
            this.Id = Guid.NewGuid();
            this.CreatedDate = DateTime.Now;
            this.LastUpdateDate = DateTime.Now;
            this.Tags = new List<string>();
        }
        public Guid Id { get; init; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public string LastUpdatedBy { get; set; }

        public List<string> RolesAllowedToRead { get; set; }

        public List<string> IdsAllowedToRead { get; set; }

        public List<string> RolesAllowedToUpdate { get; set; }

        public List<string> IdsAllowedToUpdate { get; set; }

        public List<string> RolesAllowedToWrite { get; set; }

        public List<string> IdsAllowedToWrite { get; set; }

        public List<string> RolesAllowedToDelete { get; set; }

        public List<string> IdsAllowedToDelete { get; set; }

        public List<string> Tags { get; set; }




    }
}
