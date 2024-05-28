using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBuy.Core.Entities
{
    public class Person : BaseEntity
    {
        public string Email { get; set; }

        public string DisplayName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string ProfileImageUrl { get; set; }

        public string UserId { get; set; }
    }
}
