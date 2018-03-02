namespace FindItFast.Backend.Models
{
    using System.Data.Entity;
    using FindItFast.Domain;
    using FindItFast.Domain.Models;

    public class LocalDataContext : DataContext
    {
        public DbSet<User> Users { get; set; }
    }
}