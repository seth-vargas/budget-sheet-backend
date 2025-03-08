
namespace BudgetSheetApi.Services
{
    public class ErrorHandlerService : IErrorHandlerService
    {
        private readonly ILoggerService _logger;

        public ErrorHandlerService(ILoggerService logger)
        {
            _logger = logger;
        }

        public void HandleError(Exception ex)
        {
            _logger.LogError("An error occured", ex);
        }
    }
}