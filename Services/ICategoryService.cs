using BudgetSheetApi.Data.Entities;
using BudgetSheetApi.Models;

namespace BudgetSheetApi.Services
{
    public interface ICategoryService : IBaseService
    {
        Task<CategoryModel> CreateCategory(NewCategory newCategory);

        Task<BaseListResponseModel<Category>> GetCategories();
    }
}