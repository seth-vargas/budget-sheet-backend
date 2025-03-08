namespace BudgetSheetApi.Models
{
    public class BaseModel
    {
        public bool IsValid { get; set; } = false;


        public string Message { get; set; } = "";

        public void SetSuccess(string message)
        {
            IsValid = true;
            Message = message;
        }

        public void HandleError(Exception ex, string? message = null)
        {
            IsValid = false;

            if (string.IsNullOrWhiteSpace(message))
            {
                Message = $"An error occured: {ex.Message} - {ex.StackTrace}";
            }
            else
            {
                Message = message;
            }
        }
    }
}