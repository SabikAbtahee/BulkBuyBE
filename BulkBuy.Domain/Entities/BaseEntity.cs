using BulkBuy.Domain.Common.Constants;
using BulkBuy.Domain.Interfaces;
namespace BulkBuy.Domain.Entities
{
    public class BaseEntity : IBaseEntity
    {

        public BaseEntity()
        {
            Id = Guid.NewGuid();
            SetAdminRoles();
            SetBeforeCreation();
        }

        public Guid Id { get; init; }

        public Guid CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public Guid LastUpdatedBy { get; set; }

        public List<string> RolesAllowedToRead { get; set; }

        public List<Guid> IdsAllowedToRead { get; set; }

        public List<string> RolesAllowedToUpdate { get; set; }

        public List<Guid> IdsAllowedToUpdate { get; set; }

        public List<string> RolesAllowedToWrite { get; set; }

        public List<Guid> IdsAllowedToWrite { get; set; }

        public List<string> RolesAllowedToDelete { get; set; }

        public List<Guid> IdsAllowedToDelete { get; set; }

        public void SetIdsForCreation(Guid UserId)
        {
            IdsAllowedToRead = new List<Guid> { UserId };
            IdsAllowedToUpdate = new List<Guid> { UserId };
            IdsAllowedToDelete = new List<Guid> { UserId };
            IdsAllowedToWrite = new List<Guid> { UserId };
            CreatedBy = UserId;
            LastUpdatedBy = UserId;
        }
        public void SetBeforeCreation()
        {
            CreatedDate = DateTime.UtcNow;
            LastUpdateDate = DateTime.UtcNow;
        }
        public void SetBeforeUpdate(Guid? Id = null)
        {
            LastUpdateDate = DateTime.UtcNow;
            if (Id is not null)
            {
                LastUpdatedBy = (Guid)Id;
            }
        }

        public void SetAdminRoles()
        {
            RolesAllowedToRead = new List<string> { RoleTypes.Admin };
            RolesAllowedToUpdate = new List<string> { RoleTypes.Admin };
            RolesAllowedToDelete = new List<string> { RoleTypes.Admin };
            RolesAllowedToWrite = new List<string> { RoleTypes.Admin };
        }
    }
}
