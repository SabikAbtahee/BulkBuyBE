using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBuy.Core.Entities
{
    public class Location : BaseEntity
    {
        public string Area { get; set; }
        public string Description { get; set; }
        public bool IsAvailable { get; set; }

        // may give coordinates 
    }
}
