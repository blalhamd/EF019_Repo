

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace EF019 // don't forget to add it in configuration.
{
    public class SoftDeleteInterceptor : SaveChangesInterceptor // built-in in .Net
    {
        // will override for method that return int
        public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
        {
            foreach (var entry in eventData.Context.ChangeTracker.Entries())
            {
                if (entry.State == EntityState.Deleted && entry.Entity is ISoftDelete softDeletable)
                {
                    // Perform soft delete by updating an IsDeleted property
                    entry.State = EntityState.Modified;
                    softDeletable.Delete();
                }
            }

            return base.SavingChanges(eventData, result);
        }
    }

}
