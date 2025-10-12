using PROJECT_BOOK_STORE_GROUP5_PRN222.Models;
using PROJECT_BOOK_STORE_GROUP5_PRN222.Repositories;

namespace PROJECT_BOOK_STORE_GROUP5_PRN222.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IBaseRepository<Category> baseRepository;
        
        public async Task<IEnumerable<Category>> GetAllCategoryAsync()
        {
            var category = await baseRepository.GetAllAsync();
            if (category == null || !category.Any()) 
                throw new InvalidOperationException("No category available.");
            return category;
        }
        public async Task<Category?> GetCategoryByIdAsync(long id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid category ID.");

            var category = await baseRepository.GetByIdAsync(id);
            if (category == null)
                throw new KeyNotFoundException($"Category with ID {id} not found.");

            return category;
        }

        public async Task AddCategoryAsync(Category category)
        {
            //Validate input
            if (category == null)
                throw new ArgumentNullException("Category cannot be null");
            if (string.IsNullOrWhiteSpace(category.CategoryCode))
                throw new ArgumentException("Category code cannot be null");
            if (string.IsNullOrWhiteSpace(category.CategoryName))
                throw new ArgumentException("Category name cannot be null");
            await baseRepository.AddAsync(category);
        }

        public async Task UpdateCategoryAsync(Category category)
        {
            //Validate input
            if (category == null)
                throw new ArgumentNullException("Category cannot be null");
            if (string.IsNullOrWhiteSpace(category.CategoryCode))
                throw new ArgumentException("Category code cannot be null");
            if (string.IsNullOrWhiteSpace(category.CategoryName))
                throw new ArgumentException("Category name cannot be null");
            await baseRepository.AddAsync(category);
        }
    }
}
