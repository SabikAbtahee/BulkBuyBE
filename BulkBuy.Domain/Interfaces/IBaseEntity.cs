namespace BulkBuy.Domain.Interfaces;

public interface IBaseEntity
{
    Guid CreatedBy { get; set; }
    DateTime CreatedDate { get; set; }
    Guid Id { get; init; }
    List<Guid> IdsAllowedToDelete { get; set; }
    List<Guid> IdsAllowedToRead { get; set; }
    List<Guid> IdsAllowedToUpdate { get; set; }
    List<Guid> IdsAllowedToWrite { get; set; }
    DateTime LastUpdateDate { get; set; }
    Guid LastUpdatedBy { get; set; }
    List<string> RolesAllowedToDelete { get; set; }
    List<string> RolesAllowedToRead { get; set; }
    List<string> RolesAllowedToUpdate { get; set; }
    List<string> RolesAllowedToWrite { get; set; }

    void SetBeforeCreation();
    void SetBeforeUpdate(Guid? Id);
    void SetIdsForCreation(Guid UserId);
    void SetAdminRoles();

}