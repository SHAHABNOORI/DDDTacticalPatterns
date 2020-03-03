using Microsoft.EntityFrameworkCore;

namespace DDDTacticalPatterns.ValueObjects.Store
{
    public class PersonContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "server=.;initial catalog=PeopleDb;user id=sa;password=P@ssw0rdM@n;MultipleActiveResultSets=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().OwnsOne(c => c.FullName); 
            //modelBuilder.Entity<Person>().Property(p => p.FullName)
            //    .HasConversion(f => f.ToString(),
            //        d => FullName.CreateFromString(d));
            //base.OnModelCreating(modelBuilder);
        }

         public DbSet<Person> Persons { get; set; }
    }
}