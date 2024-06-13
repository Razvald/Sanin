using LogProject.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace LogProject.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Area> Areas { get; set; }
        public DbSet<AreaPoint> AreaPoints { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Operator> Operators { get; set; }
        public DbSet<Picket> Pickets { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<ProfilePoint> ProfilePoints { get; set; }
        public DbSet<Project> Projects { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData(modelBuilder);
        }

        private static void SeedData(ModelBuilder modelBuilder)
        {
            var areas = new List<Area>
            {
                new() { Id = 1, Name = "qwerty", ProjectId = 1 },
                new() { Id = 2, Name = "asdfgh", ProjectId = 2 },
                new() { Id = 3, Name = "zxcvbn", ProjectId = 3 }
            };

            var areaPoints = new List<AreaPoint>
            {
                new() { Id = 1, X = 1, Y = 1, AreaId = 1 },
                new() { Id = 2, X = 7, Y = 3, AreaId = 2 },
                new() { Id = 3, X = 13, Y = 5, AreaId = 3 }
            };

            var customers = new List<Customer>
            {
                new() { Id = 1, Name = "Asd", Phone = "123456" },
                new() { Id = 2, Name = "Qwe", Phone = "654321" },
                new() { Id = 3, Name = "Zxc", Phone = "123321" }
            };

            var operators = new List<Operator>
            {
                new() { Id = 1, Name = "Pduwnw", Username = "1", Password = "1", Role = Role.Administrator },
                new() { Id = 2, Name = "Hiwpkd", Username = "2", Password = "2", Role = Role.Worker },
                new() { Id = 3, Name = "Kmcfow", Username = "3", Password = "3", Role = Role.Worker },
                new() { Id = 4, Name = "Uabhdo", Username = "4", Password = "4", Role = Role.Worker }
            };

            var pickets = new List<Picket>
            {
                new Picket { Id = 1, X = 25, Y = 23, Value = 48, ProfileId = 1 },
                new Picket { Id = 2, X = 19, Y = 28, Value = 47, ProfileId = 2 },
                new Picket { Id = 3, X = 31, Y = 20, Value = 51, ProfileId = 3 },
                new Picket { Id = 4, X = 22, Y = 30, Value = 50, ProfileId = 1 },
                new Picket { Id = 5, X = 27, Y = 25, Value = 49, ProfileId = 2 },
                new Picket { Id = 6, X = 30, Y = 18, Value = 52, ProfileId = 3 }
            };

            var profiles = new List<Profile>
            {
                new() { Id = 1, AreaId = 1, OperatorId = 2 },
                new() { Id = 2, AreaId = 2, OperatorId = 3 },
                new() { Id = 3, AreaId = 3, OperatorId = 4 },
            };

            var profilePoints = new List<ProfilePoint>
            {
                new ProfilePoint { Id = 1, X = 56, Y = 10, ProfileId = 1 },
                new ProfilePoint { Id = 2, X = 60, Y = 16, ProfileId = 2 },
                new ProfilePoint { Id = 3, X = 52, Y = 11, ProfileId = 3 },
                new ProfilePoint { Id = 4, X = 58, Y = 14, ProfileId = 1 },
                new ProfilePoint { Id = 5, X = 55, Y = 18, ProfileId = 2 },
                new ProfilePoint { Id = 6, X = 53, Y = 12, ProfileId = 3 }
            };

            var projects = new List<Project>
            {
                new() { Id = 1, Name = "pdfjwim", Address = "iuhdn 1/3", CustomerId = 1 },
                new() { Id = 2, Name = "dojwkwd", Address = "swfomc 4/23", CustomerId = 2 },
                new() { Id = 3, Name = "gkmfoww", Address = "aqefomkef 24/1", CustomerId = 3 }
            };

            modelBuilder.Entity<Area>().HasData(areas);
            modelBuilder.Entity<AreaPoint>().HasData(areaPoints);
            modelBuilder.Entity<Customer>().HasData(customers);
            modelBuilder.Entity<Operator>().HasData(operators);
            modelBuilder.Entity<Picket>().HasData(pickets);
            modelBuilder.Entity<Profile>().HasData(profiles);
            modelBuilder.Entity<ProfilePoint>().HasData(profilePoints);
            modelBuilder.Entity<Project>().HasData(projects);
        }
    }
}
