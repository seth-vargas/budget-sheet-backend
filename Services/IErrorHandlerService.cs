namespace BudgetSheetApi.Services
{
    public interface IErrorHandlerService
    {
        void HandleError(Exception ex);
    }
}