using BudgetSheetApi.Data;
using BudgetSheetApi.Data.Entities;
using BudgetSheetApi.Middleware;
using BudgetSheetApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BudgetSheetApi.Services
{
    public class FrostTransactionService : IFrostTransactionService
    {
        private readonly BudgetSheetContext _context;

        public FrostTransactionService(BudgetSheetContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<FrostTransaction>> GetTransactions()
        {
            var transactions = await _context.Transactions
                .ToListAsync();

            return transactions;
        }

        public async Task<FrostTransaction> GetTransaction(long id)
        {
            var transaction = await _context.Transactions
                .Where(t => t.Id == id)
                .FirstOrDefaultAsync();

            if (transaction == null)
            {
                throw new NotFoundException($"Transaction with id {id} not found.");
            }

            return transaction;
        }

        public Task CreateTransaction(NewFrostTransaction data)
        {
            throw new NotImplementedException();
        }
    }
}