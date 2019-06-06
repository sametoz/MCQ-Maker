using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proje.Entity.Model
{
    public class Role
    {
        public int RoleID { get; set; }
        public string RoleText { get; set; }
        [Required]
        public User User { get; set; }
        public int UserID { get; set; }
    }
}
