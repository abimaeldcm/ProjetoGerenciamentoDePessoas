using GerenciamentoDePessoas.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoDePessoas.Data
{
    public class GerenciamentoDePessoasContext : DbContext
    {
        public GerenciamentoDePessoasContext(DbContextOptions<GerenciamentoDePessoasContext> options) : base(options)
        {
        }
        public DbSet<Pessoas> Pessoas { get; set; }
    }
}
