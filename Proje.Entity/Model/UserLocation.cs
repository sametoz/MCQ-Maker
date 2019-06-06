using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proje.Entity.Model
{
   public class UserLocation
    {
        public int UserLocationId { get; set; }
        public int LocationName { get; set; }
        public int LocationCoordinated { get; set; }
        [Required]
        public User User { get; set; }
        public int UserID { get; set; }

    }
}
