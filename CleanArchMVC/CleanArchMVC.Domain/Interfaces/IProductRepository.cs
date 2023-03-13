using CleanArchMVC.Domain.Entities;

namespace CleanArchMVC.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<IEnumerable<Product>> GetProductCategoryAsync(int id);
        Task<IEnumerable<Product>> GetProductsByCategoryAsync(int idCategory);
        Task<Product> GetProductByIdAsync(int id);
        Task<Product> AddAsync(Product product);
        Task<Product> UpdateAsync(Product product);
        Task<Product> RemoveAsync(Product product);
    }
}
