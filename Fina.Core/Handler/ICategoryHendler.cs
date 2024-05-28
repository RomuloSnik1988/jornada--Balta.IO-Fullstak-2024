using Fina.Core.Models;
using Fina.Core.Requests.Categories;
using Fina.Core.Responses;

namespace Fina.Core.Handler;


public interface ICategoryHendler
{
    Task<Response<Category?>> CreateAsync(CreateCategoryRequest request);
    Task<Response<Category?>> UpdateAsync(CreateCategoryRequest request);
    Task<Response<Category?>> DeleteAsync(CreateCategoryRequest request);
    Task<Response<Category?>> GetByIdAsync(CreateCategoryRequest request);
    Task<PagedResponse<List<Category?>>> GetByIdAsync(GetAllCategoryRequest request);
}
