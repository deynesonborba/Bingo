namespace Bingo
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class Context : DbContext
    {
        public Context()
            : base("Modelos")
        {
           Configuration.LazyLoadingEnabled = false;
           Configuration.ProxyCreationEnabled = false;
           Configuration.AutoDetectChangesEnabled = true;
        }

         public DbSet<Apostador> Apostadores { get; set; }
         public DbSet<Cartela> Cartelas { get; set; }
         public DbSet<Brinde> Brindes { get; set; }
         public DbSet<Rodada> Rodadas { get; set; } 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            // Database.SetInitializer<Context>(new DropCreateDatabaseAlways<Context>());
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }       
    }
}