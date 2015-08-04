using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBB.Model
{
 public class Offer
 {
  public long ID { get; set; }
  public string ShortDescription { get; set; }
  public string LongDescription { get; set; }

  public virtual Company Company { get; set; }
 }
}
