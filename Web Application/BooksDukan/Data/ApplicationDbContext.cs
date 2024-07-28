
using BooksDukan.Models;
using Microsoft.EntityFrameworkCore;

namespace  BooksDukan.Data{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
        public DbSet<Category>Categories {get; set;}
        public DbSet<Products>Product {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category {Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category {Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category {Id = 3, Name = "History", DisplayOrder = 3 }
            );
            modelBuilder.Entity<Products>().HasData(
                new Products {Id=1,Title = "Paradoxical Sajid",ISBN="CA-9B08",Author="Arif Azad",Description="Description",Price=99,Price50=70,Price100=50,CategoryId=2,ImageUrl=""}
                
            );
        }
       
    }
}