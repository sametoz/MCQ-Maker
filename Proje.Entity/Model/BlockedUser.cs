using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proje.Entity.Model
{
    public class BlockedUser
    {
        public int BlockedUserID { get; set; }
        [Required]
        public User User { get; set; }
        public int UserID { get; set; }

    }
}
