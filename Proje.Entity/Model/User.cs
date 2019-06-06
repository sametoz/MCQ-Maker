using System.Collections.Generic;

namespace Proje.Entity.Model
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Gender { get; set; }
        public string Token { get; set; }
        public ICollection<Role> Role { get; set; }
        public ICollection<UserStarAndComment> UserStarAndComments { get; set; }
        public ICollection<UserTime> UserTime { get; set; }
        public ICollection<Avatar> Avatar { get; set; }
        public ICollection<UserLocation> UserLocation { get; set; }
        public ICollection<Message> Message { get; set; }
        public ICollection<OldPassword> OldPassword { get; set; }
        public ICollection<UserPassword> UserPassword { get; set; }
        public ICollection<Password> Password { get; set; }
        public ICollection<Contact> Contact { get; set; }
        public ICollection<UniCity> UniCities { get; set; }


    }
}
