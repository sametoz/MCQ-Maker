using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proje.Entity.Model
{
   public class Message
    {
        public int MessageID { get; set; }
        public int To { get; set; }
        public string Title { get; set; }
        public int Body { get; set; }
        public int From { get; set; }
        public bool IsRead { get; set; }
        [Required]
        public DateTime Time { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public User User { get; set; }
        public int UserID { get; set; }

    }
}
