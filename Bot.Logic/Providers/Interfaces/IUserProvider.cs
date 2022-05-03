using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Bot.Data.Enums;
using Bot.Data.Models;

namespace Bot.Logic.Providers.Interfaces;

/// <summary>
/// Сервис для получения пользователей.
/// </summary>
public interface IUserProvider
{
    /// <summary>
    /// Получает список всех пользователей.
    /// </summary>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Список всех пользователей.</returns>
    Task<IEnumerable<User>> GetAllUsers(CancellationToken cancellationToken = default);

    /// <summary>
    /// Получает пользователей по фильтру. <br/>
    /// <strong>Пока не используется.</strong>
    /// </summary>
    /// <param name="filter">Фильтр.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Список отфильтрованных пользователей.</returns>
    Task<IEnumerable<User>> GetUsersByFilter(Expression<Func<User, bool>> filter, CancellationToken cancellationToken = default);

    /// <summary>
    /// Получает пользователей по фильтру.<br/>
    /// <strong>Пока не используется.</strong>
    /// </summary>
    /// <param name="filter">Фильтр.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><see cref="User"/>.</returns>
    Task<User?> GetOneUserByFilter(Expression<Func<User, bool>> filter, CancellationToken cancellationToken = default);

    /// <summary>
    /// Получает все роли по идентификатору пользователя.
    /// </summary>
    /// <param name="userId">Идентификатор пользователя.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Роли пользователя.</returns>
    Task<Role?> GetUserRoles(long userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Получает пользователя по идентификатору.
    /// </summary>
    /// <param name="userId">Идентификатор пользователя.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns><see cref="User"/>.</returns>
    Task<User?> GetUserById(long userId, CancellationToken cancellationToken = default);
}