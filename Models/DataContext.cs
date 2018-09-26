using Microsoft.EntityFrameworkCore;

namespace TrabalhoChamados.Models
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)   
            {}

            public DbSet<Chamado> Chamados {get;set;}

            public DbSet<Cliente> Clientes {get; set;}

             public DbSet<Situacao> Situacoes {get; set;}

    }
    
}