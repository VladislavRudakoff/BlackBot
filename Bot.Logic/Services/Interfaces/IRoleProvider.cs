using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Bot.Data.Enums;

namespace Bot.Logic.Services.Interfaces
{
    /// <summary>
    /// Сервис для получения ролей.
    /// </summary>
    public interface IRoleProvider
    {
        /// <summary>
        /// Получает список всех ролей.
        /// </summary>
        /// <param name="cancellationToken">Маркер отмены.</param>
        /// <returns>Список всех ролей.</returns>
        Task<IEnumerable<Role>> GetAllRoles(CancellationToken cancellationToken = default);
    }
}