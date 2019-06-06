using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proje.Entity.Model
{
   public class Avatar
    {
        public int AvatarID { get; set; }
        public string Photo { get; set; }
        public int Type { get; set; }
        [Required]
        public User User { get; set; }
        public int UserID { get; set; }

    }
}
