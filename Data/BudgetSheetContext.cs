using BudgetSheetApi.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BudgetSheetApi.Data
{
    public class BudgetSheetContext(DbContextOptions<BudgetSheetContext> options) : DbContext(options)
    {
        public DbSet<FrostTransaction> Transactions { get; set; }


    }
}