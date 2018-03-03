namespace FindItFast.Domain
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Threading.Tasks;
    

    public class DataContext : DbContext
    {
        public DataContext() : base("FindItFastAzureConn")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }        
    }
}
