using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace contacts.Models
{
  public class Contact
  {
    [Key]
    public string phone { get; set; }
    public string first { get; set; }
    public string last { get; set; }
    public string email { get; set; }
  }
}
