using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proje.Entity.Model
{
   public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        [Required]
        public Advert Advert { get; set; }
        public int AdvertID { get; set; }

    }
}
