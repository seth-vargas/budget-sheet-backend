namespace BudgetSheetApi.Data.Entities
{
    public class FrostTransaction
    {
        public long Id { get; set; }

        public DateTime Date { get; set; }

        public required string Description { get; set; }

        public string? Memo { get; set; }

        public decimal Amount { get; set; }
    }
}