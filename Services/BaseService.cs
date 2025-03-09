using BudgetSheetApi.Models;
using BudgetSheetApi.Services;

public class BaseService : IBaseService
{
    private readonly ILoggerService _logger;
    private readonly IErrorHandlerService _errorHandler;

    public BaseService(ILoggerService logger, IErrorHandlerService errorHandler)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _errorHandler = errorHandler ?? throw new ArgumentNullException(nameof(errorHandler));
    }

    public void LogInfo(string message)
    {
        _logger.LogInfo(message);
    }

    public void LogError(string message, Exception ex)
    {
        _logger.LogError(message, ex);
    }

    public void HandleError(Exception ex)
    {
        _errorHandler.HandleError(ex);
    }
}
