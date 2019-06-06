using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proje.Entity.Model
{
   public class Email
    {
        public int EmailID { get; set; }
        public string EmailText { get; set; }
        public ICollection<Contact> contacts { get; set; }

    }
}
