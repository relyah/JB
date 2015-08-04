using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBB.Model
{
    public class Company
    {
     public long ID { get; set; }
     public string Name { get; set; }

     public virtual ICollection<Offer> Offers { get; set; }
    }
}
