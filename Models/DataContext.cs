using Microsoft.EntityFrameworkCore;

namespace TrabalhoChamados.Models
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)   
            {}

            public DbSet<Chamados> Chamados {get;set;}
    }
    
}