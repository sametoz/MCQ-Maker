using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proje.Entity.Model
{
    public class Password
    {
        public int PasswordId { get; set; }
        public string Pass { get; set; }
        public ICollection<OldPassword> OldPassword { get; set; }
        public ICollection<UserPassword> UserPassword { get; set; }
        [Required]
        public User User { get; set; }
        public int UserID { get; set; }
    }
}
