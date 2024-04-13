using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FinancialOrganizer.Data;

public class FinancialOrganizerDbContext : DbContext
{
    public FinancialOrganizerDbContext(DbContextOptions<FinancialOrganizerDbContext> options) : base(options)
    {
    }
    
    public DbSet<Transactions> Transactions { get; set; }
    public DbSet<Categories> Categories { get; set; }
    public DbSet<PaymentMethods> PaymentMethods { get; set; }
}