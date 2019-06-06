using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proje.Entity.Model
{
    public class AdvertStatus
    {
        public int AdvertStatusID { get; set; }
        public string StatusText { get; set; }
        [Required]
        public Advert Advert { get; set; }
        public int AdvertID { get; set; }

    }
}
