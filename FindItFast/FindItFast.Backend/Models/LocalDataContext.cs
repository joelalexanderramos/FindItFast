namespace FindItFast.Backend.Models
{
    using FindItFast.Domain;

    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<FindItFast.Domain.User> Users { get; set; }
    }
}