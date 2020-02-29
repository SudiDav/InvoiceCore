using Invoice.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace Invoice.Data.AppDataContext
{
    public class InvoiceDbContext : DbContext
    {
        public InvoiceDbContext(DbContextOptions options): base(options)
        {
        }
        public DbSet<CustomerModel> Customers{ get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<StoreSettingModel> Settings { get; set; }
        public DbSet<SalesModel> Sales { get; set; }
        public DbSet<SalesItemsModel> SaleItems { get; set; }
        public DbSet<DailyExpenses> DailyExpenses { get; set; }
        public DbSet<UserModel> Users { get; set; }
    }
}
