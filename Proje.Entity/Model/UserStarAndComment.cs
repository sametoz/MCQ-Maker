using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Proje.Entity.Model
{
   public class UserStarAndComment
    {
        public int UserStarAndCommentID { get; set; }
        public int Rate { get; set; }
        public string Comment { get; set; }
        public int CommentToUserID { get; set; }
        public int CommentUserID { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime Time { get; set; }
        [Required]
        public User User { get; set; }
        public int UserID { get; set; }

    }
}
