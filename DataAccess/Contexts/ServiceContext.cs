using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Contexts
{
    public class ServiceContext : DbContext
    {        
        public DbSet<User> Users { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<UserClaim> UserClaims { get; set; }
        public DbSet<BranchOffice> BranchOffices { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ServiceForm> ServiceForms { get; set; }
        public DbSet<SparePartList> SparePartLists { get; set; }
        public DbSet<TechnicialSpecification> TechnicialSpecifications { get; set; }

        public ServiceContext()
        {
           
        }
        public ServiceContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=SERVER_NAME;Database=DB_NAME;User=USER;Password=PASSWORD;");
            }
        }
    }
}
