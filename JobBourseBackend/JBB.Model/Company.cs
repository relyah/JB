using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBB.Model
{
    public class Company
    {
     public Company()
     {
      ID = -1;
      Name = String.Empty;
     }

     [Key]
     public long ID { get; set; }
     public string Name { get; set; }

     public virtual ICollection<Offer> Offers { get; set; }

     public override bool Equals(object obj)
     {
      Company other = obj as Company;
      if (other == null) return false;
      return other.Name.CompareTo(this.Name)==0;
     }
    }
}
