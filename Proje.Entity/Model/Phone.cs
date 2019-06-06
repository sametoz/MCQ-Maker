using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proje.Entity.Model
{
   public class Phone
    {
        public int PhoneID { get; set; }
        public string PhoneText { get; set; }
        public ICollection<Contact> contacts { get; set; }

    }
}
