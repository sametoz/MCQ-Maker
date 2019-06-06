using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proje.Entity.Model
{
   public class UserTime
    {
        public int UserTimeID { get; set; }
        public int LoginTime { get; set; }
        public int LoginDate { get; set; }
        public int LogoutTime { get; set; }
        public int LogoutDate { get; set; }
        [Required]
        public User User { get; set; }
        public int UserID { get; set; }

    }
}
