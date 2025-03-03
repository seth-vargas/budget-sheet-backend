using BudgetSheetApi.Data.Entities;
using BudgetSheetApi.Models;

namespace BudgetSheetApi.Services
{
    public interface IFrostTransactionService
    {
        Task<IEnumerable<FrostTransaction>> GetTransactions();

        Task<FrostTransaction> GetTransaction(long id);

        Task CreateTransaction(NewFrostTransaction data);
    }

}