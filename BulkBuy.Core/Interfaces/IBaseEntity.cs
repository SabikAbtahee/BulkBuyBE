﻿namespace BulkBuy.Core.Interfaces
{
    public interface IBaseEntity
    {
        string CreatedBy { get; set; }
        DateTime CreatedDate { get; set; }
        Guid Id { get; init; }
        List<string> IdsAllowedToDelete { get; set; }
        List<string> IdsAllowedToRead { get; set; }
        List<string> IdsAllowedToUpdate { get; set; }
        List<string> IdsAllowedToWrite { get; set; }
        DateTime LastUpdateDate { get; set; }
        string LastUpdatedBy { get; set; }
        List<string> RolesAllowedToDelete { get; set; }
        List<string> RolesAllowedToRead { get; set; }
        List<string> RolesAllowedToUpdate { get; set; }
        List<string> RolesAllowedToWrite { get; set; }
        List<string> Tags { get; set; }
    }
}