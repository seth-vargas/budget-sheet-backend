namespace BudgetSheetApi.Models
{
    public class CategoryModel : BaseModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
    }
}