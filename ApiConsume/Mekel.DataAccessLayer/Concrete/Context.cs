using Mekel.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mekel.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=esintugba;Initial Catalog=DakaMekel;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<Home> Home { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<Chef> Chef { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Gallery> Gallery { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<SendMessage> SendMessage { get; set; }
        public DbSet<MessageCategory> MessageCategorie { get; set; }
    }
}
