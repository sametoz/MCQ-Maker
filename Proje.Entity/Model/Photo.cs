using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proje.Entity.Model
{
  public  class Photo
    {
        public int PhotoID { get; set; }
        public string Photos { get; set; }
        public string Type { get; set; }
        public int PhotoSize { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime Time { get; set; }
        public ICollection<SharedPhoto> SharedPhotos { get; set; }
    }
}
