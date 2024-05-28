using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBuy.Core.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int LoginCount { get; set; }
        public DateTimeOffset LastLoginTime { get; set; }
        public List<string> Roles { get; set; } // can be a enum
    }
}
