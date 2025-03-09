using BudgetSheetApi.Data;
using BudgetSheetApi.Data.Entities;
using BudgetSheetApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BudgetSheetApi.Services
{
    public class CategoryService(ILoggerService logger, IErrorHandlerService errorHandler, BudgetSheetContext context) : BaseService(logger, errorHandler), ICategoryService
    {
        private readonly BudgetSheetContext _context = context;

        public async Task<CategoryModel> CreateCategory(NewCategory newCategory)
        {
            var response = new CategoryModel();
            const string functionName = nameof(CreateCategory);

            try
            {
                LogInfo($"Entering function {functionName}");

                var category = new Category
                {
                    Name = newCategory.Name
                };

                await _context.Categories.AddAsync(category);
                await _context.SaveChangesAsync();

                response.SetSuccess("Created new catgegory.");
            }
            catch (Exception ex)
            {
                HandleError(ex);
                response.HandleError(ex);
            }
            finally
            {
                LogInfo($"Exiting function {functionName} - {response.Message}");
            }

            return response;
        }

        public async Task<BaseListResponseModel<Category>> GetCategories()
        {
            var response = new BaseListResponseModel<Category>();
            const string functionName = nameof(GetCategories);

            try
            {
                LogInfo($"Entering function {functionName}");

                List<Category> categories = await _context.Categories
                    .ToListAsync();

                response.SetSuccess("Successfully fetched categories.");
                response.Values = categories;
            }
            catch (Exception ex)
            {
                HandleError(ex);
                response.HandleError(ex);
            }
            finally
            {
                LogInfo($"Exiting function {functionName} - {response.Message}");
            }

            return response;
        }
    }
}