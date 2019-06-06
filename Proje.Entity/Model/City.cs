using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proje.Entity.Model
{
    public class City
    {
        public int CityID { get; set; }
        public string CityText { get; set; }
        public int Count { get; set; }
        public ICollection<UniCity> UniCities { get; set; }
        [Required]
        public Advert Advert { get; set; }
        public int AdvertID { get; set; }

    }
}
