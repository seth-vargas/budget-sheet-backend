namespace BudgetSheetApi.Models
{
    public class BaseListResponseModel<T> : BaseModel
    {
        public List<T>? Values { get; set; }
    }
}