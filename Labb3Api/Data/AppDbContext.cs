using Labb3Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb3Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        
        } 

        public DbSet<User> Users { get; set; }
        public DbSet<Interests> Interests { get; set; }
        public DbSet<Links> Links { get; set; }

        public DbSet<UserConnection> UserConnection { get; set; }   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<User>().HasData(new User
            {
                UserID = 1,
                FirstName = "Anas",
                LastName = "Qlok",
                Phone = "023329248"
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                UserID = 2,
                FirstName = "Maureen",
                LastName = "Larsson",
                Phone = "072362462"
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                UserID = 3,
                FirstName = "Sara",
                LastName = "Sarasson",
                Phone = "2099425498"
            });


            modelBuilder.Entity<UserConnection>().HasData(new UserConnection
            {
                ID = 1,
                UserID = 1,
                InterestsID = 1,
                LinksID = 1,
            });
            modelBuilder.Entity<UserConnection>().HasData(new UserConnection
            {
                ID = 2,
                UserID = 2,
                InterestsID = 2,
                LinksID = 2,
            });
            modelBuilder.Entity<UserConnection>().HasData(new UserConnection
            {
                ID = 3,
                UserID = 3,
                InterestsID = 3,
                LinksID = 3,
            });
            modelBuilder.Entity<UserConnection>().HasData(new UserConnection
            {
                ID = 4,
                UserID = 2,
                InterestsID = 3,
                LinksID = 3,
            });
            modelBuilder.Entity<UserConnection>().HasData(new UserConnection
            {
                ID = 5,
                UserID = 3,
                InterestsID = 4,
                LinksID = 4,
            });
            modelBuilder.Entity<UserConnection>().HasData(new UserConnection
            {
                ID = 6,
                UserID = 3,
                InterestsID = 5,
                LinksID = 5,
            });
            modelBuilder.Entity<UserConnection>().HasData(new UserConnection
            {
                ID = 7,
                UserID = 3,
                InterestsID = 5,
                LinksID = 6,
            });


            modelBuilder.Entity<Interests>().HasData(new Interests
            {
                InterestsID = 1,
                InterestsName = "C#",
                InterestsDescription = "C# is a programing language that are used in coding.",

            });
            modelBuilder.Entity<Interests>().HasData(new Interests
            {
                InterestsID = 2,
                InterestsName = "Read",
                InterestsDescription = "Reading different kinds of books",

            });
            modelBuilder.Entity<Interests>().HasData(new Interests
            {
                InterestsID = 3,
                InterestsName = "Football",
                InterestsDescription = "Kick a ball around and try to score",

            });
            modelBuilder.Entity<Interests>().HasData(new Interests
            {
                InterestsID = 4,
                InterestsName = "Skateboarding",
                InterestsDescription = "Wooden board with wheels",

            });
            modelBuilder.Entity<Interests>().HasData(new Interests
            {
                InterestsID = 5,
                InterestsName = "Coffee",
                InterestsDescription = "Coffee is made out of roasted beans, fun to make and drink",

            });

            modelBuilder.Entity<Links>().HasData(new Links
            {
                LinkID = 1,
                Link = "https://en.wikipedia.org/wiki/C_Sharp_(programming_language)"
            });
            modelBuilder.Entity<Links>().HasData(new Links
            {
                LinkID = 2,
                Link = "https://www.amazon.com/books-used-books-textbooks/b?ie=UTF8&node=283155"
            });
            modelBuilder.Entity<Links>().HasData(new Links
            {
                LinkID = 3,
                Link = "https://sv.wikipedia.org/wiki/Football"
            });
            modelBuilder.Entity<Links>().HasData(new Links
            {
                LinkID = 4,
                Link = "https://en.wikipedia.org/wiki/Skateboarding"
            });
            modelBuilder.Entity<Links>().HasData(new Links
            {
                LinkID = 5,
                Link = "https://en.wikipedia.org/wiki/Coffee"
            });
            modelBuilder.Entity<Links>().HasData(new Links
            {
                LinkID = 6,
                Link = "https://www.britannica.com/topic/coffee"
            });

        }

    }
}
