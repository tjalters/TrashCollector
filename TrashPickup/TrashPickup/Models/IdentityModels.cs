using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TrashPickup.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
            public string Address { get; set; }
            public string City { get; set; }
            public int ZipCode { get; set; }
            public string Name { get; set; }
            //public double PhoneNumber { get; set; }

        
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        //public DbSet<MembershipType> MembershipTypes { get; set; }
        //public DbSet<Customers> Customers { get; set;  }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        //public Address addresses { get; set; }
        //public System.Data.Entity.DbSet<TrashPickup.Models.Customer> Customers { get; set; }
        public DbSet<RegisterViewModel> UserRegistration { get; set; }
        public DbSet<Day> Days { get; set; }
        //public DbSet<Week> Weeks { get; set; }
        public DbSet<SetWeeklySchedule> WeeklySchedule { get; set; }
    }
}