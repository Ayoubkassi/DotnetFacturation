using Microsoft.EntityFrameworkCore;
using Facturation.Models;

namespace Facturation.Data
{
  public class FacturationContext : DbContext
  {
    public FacturationContext(DbContextOptions<FacturationContext> opt): base(opt)
    {

    }

    public DbSet<Facture> Factures { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Devi> Devis { get; set; }


  }
}
