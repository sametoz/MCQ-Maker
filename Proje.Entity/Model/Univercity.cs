using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proje.Entity.Model
{
   public class Univercity
    {
        public int UnivercityID { get; set; }
        public int UnivercityText { get; set; }
        public ICollection<UniCity> UniCities { get; set; }
        [Required]
        public Advert Advert { get; set; }
        public int AdvertID { get; set; }

    }
}
