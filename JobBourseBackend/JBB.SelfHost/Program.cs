using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace JBB.SelfHost
{
    public class Program
    {
     public static void Main(string[] args)
     {
      Console.WriteLine("Hello World");

      AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetCurrentDirectory());
      Database.SetInitializer(new JBB.DAL.EF.JBInitializer());
      var db = new JBB.DAL.EF.JBContext();
      int companyCount = db.Companies.Count();
      int offerCount = db.Offers.Count();
      Console.WriteLine("Company Count: "+companyCount+", Offer Count: "+offerCount);
     }
    }
}
