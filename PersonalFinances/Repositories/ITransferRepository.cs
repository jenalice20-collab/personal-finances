using System.Threading.Tasks;
using System.Collections.Generic;

using PersonalFinances.Models;

namespace PersonalFinances.Repositories
{
    public interface ITransferRepository
    {
        /// <summary>
        /// Get all transfers
        /// </summary>
        Task<IEnumerable<Transfer>> GetAllTransfers ();

        /// <summary>
        /// Get all pending transfers
        /// </summary>
        Task<IEnumerable<Transfer>> GetAllPendingTransfers ();

        /// <summary>
        /// Get a transfer by Id
        /// </summary>
        Task<Transfer> GetTransferById (int id);

        /// <summary>
        /// Insert a new transfer
        /// </summary>
        Task Insert (Transfer transfer);

        /// <summary>
        /// Update an existing transfer
        /// </summary>
        Task Update (Transfer transfer);

        /// <summary>
        /// Delete an existing transfer
        /// </summary>
        Task Delete (Transfer transfer);
    }
}
