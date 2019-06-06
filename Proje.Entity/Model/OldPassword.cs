using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proje.Entity.Model
{
   public class OldPassword
    {
        public int OldPasswordID { get; set; }
        public int OldPass { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public Password Password { get; set; }
        public int PasswordID { get; set; }

    }
}
