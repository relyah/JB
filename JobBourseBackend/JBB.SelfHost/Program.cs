using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using JBB.WebApi;
using Microsoft.Owin.Hosting;
using AutoMapper;

namespace JBB.SelfHost
{
    public class Program
    {
     public static void Main(string[] args)
     {
      InitDB();
      InitAutoMapper();
      StartServer();
     }

     private static void InitDB()
     {
      Console.WriteLine("Init DB...");
      AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetCurrentDirectory());
      Database.SetInitializer(new JBB.DAL.EF.JBInitializer());
      var db = new JBB.DAL.EF.JBContext();
      int companyCount = db.Companies.Count();
      int offerCount = db.Offers.Count();
      Console.WriteLine("Company Count: " + companyCount + ", Offer Count: " + offerCount);

     }

     private static void StartServer()
     {
      string baseUri = "http://localhost:8080";
      Console.WriteLine("Starting web Server...");
      WebApp.Start<Startup>(baseUri);
      Console.WriteLine("Server running at {0} - press Enter to quit. ", baseUri);
      Console.ReadLine();
     }

     private static void InitAutoMapper()
     {
      Mapper.CreateMap<JBB.Model.Company, JBB.WebApi.Models.CompanyDto>();
      Mapper.CreateMap<JBB.Model.Offer, JBB.WebApi.Models.OfferDto>();
     }
    }
}
