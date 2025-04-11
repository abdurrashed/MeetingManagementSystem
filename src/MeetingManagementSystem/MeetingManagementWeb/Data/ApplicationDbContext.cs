using MeetingManagementWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace MeetingManagementWeb.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<CorporateCustomer> Corporate_Customer_Tbl { get; set; }
        public DbSet<IndividualCustomer> Individual_Customer_Tbl { get; set; }
        public DbSet<Product> Products_Service_Tbl { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CorporateCustomer>().HasData(
                new CorporateCustomer { Id = new Guid("b2ef4b41-a7ef-4f01-985e-a805a2d835cf"), Name = "Generation-Next IT" },
                new CorporateCustomer { Id = new Guid("859f0788-3d16-46d3-9421-44802b1e0259"), Name = "XYZ IT" },
                new CorporateCustomer { Id = new Guid("0267480b-8765-4347-b5d1-18b8d18358ae"), Name = "FYZ IT" }
            );

            modelBuilder.Entity<IndividualCustomer>().HasData(
                new IndividualCustomer { Id = new Guid("39ea6912-30dd-4626-8426-a8fa39256a2c"), Name = "Abdur Rashed" },
                new IndividualCustomer { Id = new Guid("7a5c3041-7e48-40b0-b475-1cdf4bcfafa1"), Name = "Milon Patwary" },
                new IndividualCustomer { Id = new Guid("923829fa-54ca-40aa-a0c1-4f121f7a7338"), Name = "Rakib Ahmed" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = new Guid("050f85ac-aa29-429a-a335-653cd09a196b"), Name = "Consulting", Unit = "Hour" },
                new Product{ Id = new Guid("ce9466d9-8491-4408-aeeb-a4880d2063e0"), Name = "Software License", Unit = "Piece" },
                new Product { Id = new Guid("cd7b345b-3037-4216-8065-9f8d69966ae1"), Name = "Hardware Device", Unit = "Unit" }
            );
        }
       


    }
}
