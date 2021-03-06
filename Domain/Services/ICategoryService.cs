using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.API.Domain.Communication;
using Supermarket.API.Domain.Models;

namespace Supermarket.API.Domain.Services
{
  public interface ICategoryService
  {
    Task<IEnumerable<Category>> ListAsync();

    Task<CategoryResponse> SaveAsync(Category category);

    Task<CategoryResponse> UpdateAsync(int id, Category category);

    Task<CategoryResponse> DeleteAsync(int id);
  }
}