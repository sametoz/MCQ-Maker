using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proje.Entity.Model
{
   public class SharedPhoto
    {
        public int SharedPhotoID { get; set; }
        [Required]
        public Photo Photo { get; set; }
        public int PhotoID { get; set; }

        [Required]
        public Advert Advert { get; set; }
        public int AdvertID { get; set; }


    }
}
