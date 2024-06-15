namespace BulkBuy.Domain.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? LoginCount { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public List<string> Roles { get; set; }
    }
}
