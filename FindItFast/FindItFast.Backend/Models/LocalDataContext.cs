namespace FindItFast.Backend.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web;
    using FindItFast.Domain;
    using FindItFast.Domain.Models;

    public class LocalDataContext : DataContext
    {
        public DbSet<User> Users { get; set; }

        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is User && (x.State == EntityState.Added || x.State == EntityState.Modified));

            var currentUsername = !string.IsNullOrEmpty(System.Web.HttpContext.Current?.User?.Identity?.Name)
                ? HttpContext.Current.User.Identity.Name
                : "Anonymous";

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((User)entity.Entity).CreatedDate = DateTime.UtcNow;
                    ((User)entity.Entity).CreatedById = 2;
                }

                ((User)entity.Entity).LastModifiedDate = DateTime.UtcNow;
                ((User)entity.Entity).LastModifiedById = 2;
            }
        }

        public override Task<int> SaveChangesAsync()
        {
            AddTimestamps();

            return base.SaveChangesAsync(); 
        }
    }
}