using Microsoft.EntityFrameworkCore;
using Proje.Entity.Model;
namespace Proje.DataAccess.Context
{
    public class ProjeContext:DbContext
    {
        public ProjeContext(DbContextOptions<ProjeContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Advert> Advert { get; set; }
        public DbSet<AdvertStatus> AdvertStatus { get; set; }
        public DbSet<Avatar> Avatar { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Email> Email { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<OldPassword> OldPasswords { get; set; }
        public DbSet<Password> Password { get; set; }
        public DbSet<Phone> Phone { get; set; }
        public DbSet<Photo> Photo { get; set; }
        public DbSet<RegisterTemp> RegisterTemp { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<SharedPhoto> SharedPhoto { get; set; }
        public DbSet<UniCity> UniCity { get; set; }
        public DbSet<Univercity> Univercity { get; set; }
        public DbSet<UserLocation> UserLocation { get; set; }
        public DbSet<UserPassword> UserPassword { get; set; }
        public DbSet<UserStarAndComment> UserStarAndComment { get; set; }
        public DbSet<UserTime> UserTime { get; set; }
        public DbSet<FavAdvert> FavAdvert { get; set; }
        public DbSet<Complaint> Complaint { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<NotificationType> NotificationType { get; set; }
        public DbSet<BlockedUser> BlockedUser { get; set; }
        public DbSet<AdvertSeenUser> AdvertSeenUser { get; set; }
    }
}
