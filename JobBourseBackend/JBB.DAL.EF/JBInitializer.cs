using JBB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBB.DAL.EF
{
 public class JBInitializer  : System.Data.Entity.DropCreateDatabaseIfModelChanges<JBContext>
 {
  protected override void Seed(JBContext context)
  {
   //base.Seed(context);

   var companies = new List<Company> {
    new Company{Name="Haagi Mettals"},
    new Company{Name="Morkels Manufacture Pty Ltd"}
   };
   companies.ForEach(c => context.Companies.Add(c));
   context.SaveChanges();

   var offers = new List<Offer>
   {
    new Offer{Company=companies[0],ShortDescription="Motor Maintenance", LongDescription="A student is required to maintain electric motors for the companies manufacturing division."},
    new Offer{Company=companies[0], ShortDescription="Quality Assurance", LongDescription="A student is required to test the diameter of the product. Tcl/Tk and basic electronic skills (soldering) required."},
    new Offer{Company=companies[1], ShortDescription="Lathe Operator", LongDescription="Partime work to earn some extras cash by operating a lathe in our furniture workshop in Doornfontein."}
   };
   offers.ForEach(o => context.Offers.Add(o));
   context.SaveChanges();

  }
 }
}
