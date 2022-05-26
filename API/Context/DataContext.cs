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
    }
}
