using ErasmusDDD.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ErasmusDDD.Data.Context
{
    public class ErasmusDDDContext : DbContext
    {
        public ErasmusDDDContext() : base("ErasmusDDD") { }

        public DbSet<Livro> Livros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
