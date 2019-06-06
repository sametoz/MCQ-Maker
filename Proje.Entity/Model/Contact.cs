using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proje.Entity.Model
{
    public class Contact
    {
        public int ContactID { get; set; }
        public int EmailID { get; set; }
        public int PhoneID { get; set; }
        [Required]
        public User User { get; set; }
        public int UserID { get; set; }

    }
}
