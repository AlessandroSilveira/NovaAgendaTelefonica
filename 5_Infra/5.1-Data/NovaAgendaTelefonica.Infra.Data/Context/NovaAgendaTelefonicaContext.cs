
using Microsoft.EntityFrameworkCore;

namespace NovaAgendaTelefonica.Infra.Data.Context
{
    public class NovaAgendaTelefonicaContext : DbContext
    {
        public NovaAgendaTelefonicaContext()
            :base("DefaultConnection")
        {
            
        }

        public DbSet<Contato> Contatos {get;set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity));
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            base.OnModelCreating(modelBuilder);
        }
        
    }
} 