using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proje.Entity.Model
{
    public class FavAdvert
    {
        public int FavAdvertID { get; set; }
        [Required]
        public User User { get; set; }
        public int UserID { get; set; }
        [Required]
        public Advert Advert { get; set; }
        public int AdvertID { get; set; }

    }
}
