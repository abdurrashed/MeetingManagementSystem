using MeetingManagementWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace MeetingManagementWeb.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<CorporateCustomer> Corporate_Customer_Tbl { get; set; }
        public DbSet<IndividualCustomer> Individual_Customer_Tbl { get; set; }
        public DbSet<ProductService> Products_Service_Tbl { get; set; }


    }
}
