using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BulkBuy.Core.Interfaces;
namespace BulkBuy.Core.Entities
{
    public class BaseEntity : IBaseEntity
    {

        public BaseEntity()
        {
            this.Id = Guid.NewGuid();
            this.CreatedDate = new DateTimeOffset();
            this.LastUpdateDate = new DateTimeOffset();
            this.Tags = new List<string>();
        }
        public Guid Id { get; init; }

        public string CreatedBy { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset LastUpdateDate { get; set; }

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
