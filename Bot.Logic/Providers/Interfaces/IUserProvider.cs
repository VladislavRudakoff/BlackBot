using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Bot.Data.DboModels;
using Bot.Data.Enums;

namespace Bot.Logic.Providers.Interfaces;

/// <summary>
/// Сервис для получения пользователей.
/// </summary>
public interface IUserProvider
{
    /// <summary>
    /// Возвращает список всех пользователей.
    /// </summary>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Список всех пользователей.</returns>
    Task<IEnumerable<UserDbo>> GetAllUsersAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Возвращает пользователей по фильтру. <br/>
    /// <strong>Пока не используется.</strong>
    /// </summary>
    /// <param name="filter">Фильтр.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Список отфильтрованных пользователей.</returns>
    Task<IEnumerable<UserDbo>> GetUsersByFilterAsync(Expression<Func<UserDbo, bool>> filter, CancellationToken cancellationToken = default);

    /// <summary>
    /// Возвращает пользователя по фильтру.<br/>
    /// <strong>Пока не используется.</strong>
    /// </summary>
    /// <param name="filter">Фильтр.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Пользователь, полученный по фильтру.</returns>
    Task<UserDbo?> GetOneUserByFilterAsync(Expression<Func<UserDbo, bool>> filter, CancellationToken cancellationToken = default);

    /// <summary>
    /// Возвращает все роли по идентификатору пользователя.
    /// </summary>
    /// <param name="userId">Идентификатор пользователя.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Роли пользователя.</returns>
    Task<Roles> GetUserRolesAsync(long userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Возвращает пользователя по идентификатору.
    /// </summary>
    /// <param name="userId">Идентификатор пользователя.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Пользователь, найденный по идентификатору.</returns>
    Task<UserDbo?> GetUserByIdAsync(long userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Возвращает пользователя по юзернейму.
    /// </summary>
    /// <param name="username">Юзернейм пользователя.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Пользователь, найденный по юзернейму.</returns>
    Task<UserDbo?> GetUserByUsernameAsync(string username, CancellationToken cancellationToken = default);
}