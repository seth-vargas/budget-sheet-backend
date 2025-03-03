using BudgetSheetApi.Data;
using BudgetSheetApi.Data.Entities;
using BudgetSheetApi.Models;
using BudgetSheetApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BudgetSheetApi.Controllers
{
    [Route("api/Transactions")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly BudgetSheetContext _context;
        private readonly IFrostTransactionService _transactionService;

        public TransactionController(BudgetSheetContext context, IFrostTransactionService transactionService)
        {
            _context = context;
            _transactionService = transactionService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FrostTransaction>>> GetTransactions()
        {
            var transactions = await _transactionService.GetTransactions();
            return Ok(transactions);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FrostTransaction>> GetTransaction(long id)
        {
            var transaction = await _transactionService.GetTransaction(id);
            return Ok(transaction);
        }

        [HttpPost]
        public async Task<ActionResult> CreateTransaction(NewFrostTransaction transaction)
        {
            await _transactionService.CreateTransaction(transaction);
            return Ok();
        }
    }
}