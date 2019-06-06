using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proje.Entity.Model
{
    public class UserPassword
    {
        public int UserPasswordID { get; set; }
        [Required]
        public Password Password { get; set; }
        public int PasswordID { get; set; }

        [Required]
        public User User { get; set; }
        public int UserID { get; set; }

    }
}
