using CrontroleDeContatos.Entidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CrontroleDeContatos.Data
{
    public class BancoContext : DbContext 
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) 
        {
        }
        public DbSet<Contatos> Contatos { get; set; }
    }
}
