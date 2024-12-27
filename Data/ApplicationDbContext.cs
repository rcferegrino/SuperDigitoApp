using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SuperDigitoApp.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<CalculationHistory> CalculationHistories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure the relationship between ApplicationUser and CalculationHistory
        modelBuilder.Entity<CalculationHistory>()
            .HasOne(ch => ch.User) // Each CalculationHistory has one User
            .WithMany() // Each User can have many CalculationHistories
            .HasForeignKey(ch => ch.UserId) // Foreign Key in CalculationHistory
            .OnDelete(DeleteBehavior.Cascade); // Optionally cascade delete
    }
}