namespace FindItFast.Backend.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web;
    using FindItFast.Domain;
    using FindItFast.Domain.Models;

    public class LocalDataContext : DataContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Business> Businesses { get; set; }

        public override Task<int> SaveChangesAsync()
        {
            TrackChanges();

            return base.SaveChangesAsync();
        }

        //private void AddTimestamps<T>() where T : class
        //{
        //    var entities = ChangeTracker.Entries().Where(x => x.Entity is T && (x.State == EntityState.Added || x.State == EntityState.Modified));

        //    var currentUsername = !string.IsNullOrEmpty(System.Web.HttpContext.Current?.User?.Identity?.Name)
        //        ? HttpContext.Current.User.Identity.Name
        //        : "Anonymous";

        //    foreach (var entity in entities)
        //    {            
        //         if (entity.State == EntityState.Added)
        //        {
        //            ((poco)entity.Entity).CreatedDate = DateTime.UtcNow;
        //            ((poco)entity.Entity).CreatedById = 2;
        //        }

        //        ((poco)entity.Entity).LastModifiedDate = DateTime.UtcNow;
        //        ((poco)entity.Entity).LastModifiedById = 2;
        //    }
        //}

    private void TrackChanges()
    {
        foreach (var entry in this.ChangeTracker.Entries().Where(e => e.State == EntityState.Added || e.State == EntityState.Modified))
        {
                    if (entry.Entity is User)
                    {
                        var auditable = entry.Entity as User;

                        if (entry.State == EntityState.Added) {
                            auditable.CreatedDate = DateTime.UtcNow;
                            auditable.CreatedBy = 2;
                        }
                        else {
                            auditable.LastModifiedDate = DateTime.UtcNow;
                            auditable.LastModifiedBy = 2;
                        } 
                    }
                }
            }    

    }
}