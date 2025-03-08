namespace BudgetSheetApi.Data.Entities
{
    public class CategoryAssignment
    {
        public int Id { get; set; }

        public required string TransactionName { get; set; }

        public int CategoryId { get; set; }

        public required Category Category { get; set; }
    }
}