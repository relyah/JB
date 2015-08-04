namespace JBB.DAL.EF.Migrations
{
 using JBB.Model;
 using System;
 using System.Collections.Generic;
 using System.Data.Entity;
 using System.Data.Entity.Migrations;
 using System.Linq;

 internal sealed class Configuration : DbMigrationsConfiguration<JBB.DAL.EF.JBContext>
 {
  public Configuration()
  {
   AutomaticMigrationsEnabled = true;
  }

  protected override void Seed(JBB.DAL.EF.JBContext context)
  {
   var companies = new List<Company> {
    new Company{Name="Haagi Mettals"},
    new Company{Name="Morkels Manufacture Pty Ltd"}
   };
   companies.ForEach(c => context.Companies.AddOrUpdate(p => p.Name, c));
   context.SaveChanges();

   var offers = new List<Offer>
   {
    new Offer{Company=companies[0],ShortDescription="Motor Maintenance", LongDescription="A student is required to maintain electric motors for the companies manufacturing division."},
    new Offer{Company=companies[0], ShortDescription="Quality Assurance", LongDescription="A student is required to test the diameter of the product. Tcl/Tk and basic electronic skills (soldering) required."},
    new Offer{Company=companies[1], ShortDescription="Lathe Operator", LongDescription="Partime work to earn some extras cash by operating a lathe in our furniture workshop in Doornfontein."}
   };
   offers.ForEach(o => context.Offers.AddOrUpdate(p=>p.ShortDescription,o));
   context.SaveChanges();
  }
 }
}
