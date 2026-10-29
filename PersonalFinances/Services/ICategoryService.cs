using System.Threading.Tasks;

using PersonalFinances.Models;

namespace PersonalFinances.Services
{
    public interface ICategoryService
    {
        /// <summary>
        /// Get a category by name and type
        /// </summary>
        Task<Category> GetByName (string name, string type);
    }
}
