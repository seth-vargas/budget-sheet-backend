using BudgetSheetApi.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BudgetSheetApi.Data
{
    public class BudgetSheetContext(DbContextOptions<BudgetSheetContext> options) : DbContext(options)
    {
        public DbSet<FrostTransaction> Transactions { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<CategoryAssignment> CategoryAssignments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Transactions)
                .WithOne(t => t.Category)
                .HasForeignKey(t => t.CategoryId)
                .IsRequired(false);

            modelBuilder.Entity<Category>()
                .HasData(
                    new Category { Id = 1, Name = "None" },
                    new Category { Id = 2, Name = "Bill" },
                    new Category { Id = 3, Name = "Credit Card" },
                    new Category { Id = 4, Name = "Dining Out" },
                    new Category { Id = 5, Name = "Gas" },
                    new Category { Id = 6, Name = "Groceries" },
                    new Category { Id = 7, Name = "Hair Cut" },
                    new Category { Id = 8, Name = "Home School" },
                    new Category { Id = 9, Name = "Loan Payment" },
                    new Category { Id = 10, Name = "Medical Payment" },
                    new Category { Id = 11, Name = "Overdraft" },
                    new Category { Id = 12, Name = "Pet" },
                    new Category { Id = 13, Name = "Savings" },
                    new Category { Id = 14, Name = "Shopping" },
                    new Category { Id = 15, Name = "Subscription" }
                );
        }
    }
}