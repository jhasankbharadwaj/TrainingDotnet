using AutoMapper.model;
using Microsoft.EntityFrameworkCore;

namespace AutoMapper.Data
{
    public class PersonalDetailsContext:DbContext
    {
        public PersonalDetailsContext(DbContextOptions<PersonalDetailsContext> options) : base(options)
        {

        }
        public DbSet<PersonalDetail> PersonalDetalis { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PersonalDetail>().HasData(
                new PersonalDetail { Adhaar = 12345, Age = 12, Name = "jb", gender = "male" });
            modelBuilder.Entity<PersonalDetail>().HasData(
                new PersonalDetail { Adhaar = 123456, Age = 12, Name = "jb", gender = "male" });
            modelBuilder.Entity<PersonalDetail>().HasData(
                new PersonalDetail { Adhaar = 123457, Age = 12, Name = "jb", gender = "male" });
        }

    }
}
