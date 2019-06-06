using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.Entity.Model
{
    public class NotificationType
    {
        public int NotificationTypeID { get; set; }
        public string Type { get; set; }
        public ICollection<Notification> Notification { get; set; }
    }
}
