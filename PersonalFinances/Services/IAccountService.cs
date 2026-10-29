using System.Threading.Tasks;

namespace PersonalFinances.Services
{
    public interface IAccountService
    {
        /// <summary>
        /// Get an account name by Id
        /// </summary>
        Task<string> GetAccountNameById (int id);
    }
}
