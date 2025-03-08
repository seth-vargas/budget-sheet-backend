namespace BudgetSheetApi.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public ICollection<FrostTransaction> Transactions { get; set; } = [];
    }
}
