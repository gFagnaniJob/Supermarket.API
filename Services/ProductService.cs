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


    public async Task<IEnumerable<Product>> ListAsync()
    {
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

    public async Task<ProductResponse> UpdateAsync(int id, Product product)
    {
      var existingProduct = await _productRepository.FindByIdAsync(id);

      if (existingProduct == null)
        return new ProductResponse("Product not found.");

      var existingCategory = await _categoryRepository.FindByIdAsync(product.CategoryId);
      if (existingCategory == null)
        return new ProductResponse("Invalid category.");

      existingProduct.Name = product.Name;
      existingProduct.UnitOfMeasurement = product.UnitOfMeasurement;
      existingProduct.QuantityInPackage = product.QuantityInPackage;
      existingProduct.CategoryId = product.CategoryId;

      try
      {
        _productRepository.Update(existingProduct);
        await _unitOfWork.CompleteAsync();

        return new ProductResponse(existingProduct);
      }
      catch (Exception ex)
      {
        // Do some logging stuff
        return new ProductResponse($"An error occurred when updating the product: {ex.Message}");
      }
    }
    public async Task<ProductResponse> DeleteAsync(int id)
    {
      var existingProduct = await _productRepository.FindByIdAsync(id);

      if (existingProduct == null)
        return new ProductResponse("Product not found.");

      try
      {
        _productRepository.Delete(existingProduct);
        await _unitOfWork.CompleteAsync();

        return new ProductResponse(existingProduct);
      }
      catch (Exception e)
      {
        return new ProductResponse($"An error occurred when deleting the product: {e.Message}");
      }
    }
  }
}