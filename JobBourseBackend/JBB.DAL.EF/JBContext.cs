using JBB.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBB.DAL.EF
{
 public class JBContext : DbContext
 {
  public JBContext()
   : base("JBContext")
  {
   base.Configuration.ProxyCreationEnabled= false;


  }

  public DbSet<Company> Companies { get; set; }
  public DbSet<Offer> Offers { get; set; }

  protected override void OnModelCreating(DbModelBuilder modelBuilder)
  {
   modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
  }
 }
}
