using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proje.Entity.Model
{
    public class Advert
    {
        public int AdvertID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public bool AdvertOr { get; set; }
        public ICollection<Univercity> Univercities { get; set; }
        public ICollection<City> Cities { get; set; }
        public ICollection<UniCity> UniCities { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<SharedPhoto> SharedPhotos { get; set; }
        public ICollection<AdvertStatus> AdvertStatuses { get; set; }
        [Required]
        public User User { get; set; }
        public int UserID { get; set; }

    }
}
