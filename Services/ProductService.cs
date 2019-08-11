using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.API.Domain.Communication;
using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Repositories;
using Supermarket.API.Domain.Services;

namespace Supermarket.API.Services
{
  public class ProductService : IProductService
  {
    private readonly IProductRepository _productRepository;
    private readonly ICategoryRepository _categoryRepository;
    private readonly IUnitOfWork _unitOfWork;

    public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork, ICategoryRepository categoryRepository)
    {
      this._productRepository = productRepository;
      this._unitOfWork = unitOfWork;
      this._categoryRepository = categoryRepository;
    }

    public async Task<IEnumerable<Product>> ListAsync() {
        return await _productRepository.ListAsync();
    }

    public async Task<ProductResponse> SaveAsync(Product product)
    {
      try
      {
        var existingCategory = await _categoryRepository.FindByIdAsync(product.CategoryId);
        if (existingCategory == null)
          return new ProductResponse("Invalid Category");

        await _productRepository.AddAsync(product);
        await _unitOfWork.CompleteAsync();

        return new ProductResponse(product);
      }
      catch (Exception e)
      {
        return new ProductResponse($"An error occurred when saving the product: {e.Message}");
      }
    }
  }
}