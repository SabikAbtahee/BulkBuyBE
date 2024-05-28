using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBuy.Core.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> ProductImageUrls { get; set; }
        public int Price { get; set; } 
        public int MinimumOrderLimit{ get; set; } 
        public int MinimumPurchaseQuantity { get; set; } 
        public string UnitOfMeasurement { get; set; } // can be a enum
        public List<string> LocationIds { get; set; }


    }
}
