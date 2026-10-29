using System.Threading.Tasks;

using PersonalFinances.Models;

namespace PersonalFinances.Services
{
    public interface IMovementService
    {
        /// <summary>
        /// Add a new movement
        /// </summary>
        Task Add (Movement movement);
    }
}
