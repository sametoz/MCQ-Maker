using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proje.Entity.Model
{
    public class Notification
    {
        public int NotificationID { get; set; }
        public int ToUser { get; set; }
        public int FromUser { get; set; }
        [Required]
        public NotificationType NotificationType { get; set; }
        public int NotificationTypeID { get; set; }
    }
}
