using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proje.Entity.Model
{
   public class UniCity
    {
        [Key]
        public int? UniCityID { get; set; }
        [Required]
        public Univercity Univercity { get; set; }
        [Required]
        public City City { get; set; }
        [Required]
        public Advert Advert { get; set; }
        [Required]
        public User User { get; set; }
        public int UserID { get; set; }
        public int AdvertID { get; set; }
        public int CityID { get; set; }

    }
}
