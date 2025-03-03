namespace BudgetSheetApi.Models
{
    public class NewFrostTransaction
    {
        public DateTime Date { get; set; }

        public required string Description { get; set; }

        public required string Memo { get; set; }

        public decimal Amount { get; set; }

        public required string LongDescription { get; set; }
    }
}