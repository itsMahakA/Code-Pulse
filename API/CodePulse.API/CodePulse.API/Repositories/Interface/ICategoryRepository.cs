using CodePulse.API.Models.Domain;

namespace CodePulse.API.Repositories.Interface
{
    public interface ICategoryRepository
    {
        //Only defination not implementation
        Task<Category> CreateAsync(Category category);
    }
}
