using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }

        public DbSet<Tarefas> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Tarefas>(p =>
            {
                p.ToTable("tarefas");
                p.Property(x => x.Nome).HasMaxLength(50);
                p.Property(x => x.Descricao).HasMaxLength(140);
                p.Property(x => x.DataInicio).HasColumnType("datetime");
                p.Property(x => x.DataFim).HasColumnType("datetime");
            });
        }
    }
}
