using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.API.Domain.Communication;
using Supermarket.API.Domain.Models;

namespace Supermarket.API.Domain.Services
{
  public interface IProductService
  {
    Task<IEnumerable<Product>> ListAsync();
    Task<ProductResponse> SaveAsync(Product product);
    Task<ProductResponse> UpdateAsync(int id, Product product);
  }
}