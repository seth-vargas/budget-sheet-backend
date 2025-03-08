namespace BudgetSheetApi.Services
{
    public interface IBaseService
    {
        void LogInfo(string message);

        void LogError(string message, Exception ex);

        void HandleError(Exception ex);
    }

}