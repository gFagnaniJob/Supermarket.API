using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.API.Domain.Communication;
using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Repositories;
using Supermarket.API.Domain.Services;

namespace Supermarket.API.Services
{
  public class CategoryService : ICategoryService
  {
    private readonly ICategoryRepository _categoryRepository;
    private readonly IUnitOfWork _unitOfWork;
    public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
    {
      this._categoryRepository = categoryRepository;
      this._unitOfWork = unitOfWork;
    }
    public async Task<IEnumerable<Category>> ListAsync()
    {
      return await _categoryRepository.ListAsync();
    }

    public async Task<SaveCategoryResponse> SaveAsync(Category category)
    {
      try
      {
          await _categoryRepository.AddAsync(category);
          await _unitOfWork.CompleteAsync();

          return new SaveCategoryResponse(category);
      }
      catch (Exception e)
      {
          return new SaveCategoryResponse($"An error occurred when saving the category: {e.Message}");
      }
    }
  }
}