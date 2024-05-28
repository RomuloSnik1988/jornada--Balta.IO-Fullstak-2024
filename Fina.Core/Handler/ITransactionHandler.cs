using Fina.Core.Models;
using Fina.Core.Requests.Categories;
using Fina.Core.Responses;

namespace Fina.Core.Handler;

public interface ITransactionHandler
{
    Task<Response<Trasaction?>> CreateAsync(CreateCategoryRequest request);
    Task<Response<Trasaction?>> UpdateAsync(CreateCategoryRequest request);
    Task<Response<Trasaction?>> DeleteAsync(CreateCategoryRequest request);
    Task<Response<Trasaction?>> GetByIdAsync(CreateCategoryRequest request);
    Task<PagedResponse<List<Trasaction?>>> GetByPeridAsync(GetAllCategoryRequest request);
}
