using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBB.Model
{
 public class Offer
 {
  [Key]
  public long ID { get; set; }
  public string ShortDescription { get; set; }
  public string LongDescription { get; set; }
  public virtual Company Company { get; set; }
 }
}
