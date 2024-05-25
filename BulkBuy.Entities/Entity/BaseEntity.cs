using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBuy.Entities.Entity
{
    public class BaseEntity
    {
        public string Id { get; set; }

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
