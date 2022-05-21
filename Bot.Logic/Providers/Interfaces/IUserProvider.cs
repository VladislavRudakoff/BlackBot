using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Bot.Data.DboModels;
using Bot.Data.StandartEnum;

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
    Task<IEnumerable<UserDbo>> GetAllUsers(CancellationToken cancellationToken = default);

    /// <summary>
    /// Получает пользователей по фильтру. <br/>
    /// <strong>Пока не используется.</strong>
    /// </summary>
    /// <param name="filter">Фильтр.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Список отфильтрованных пользователей.</returns>
    Task<IEnumerable<UserDbo>> GetUsersByFilter(Expression<Func<UserDbo, bool>> filter, CancellationToken cancellationToken = default);

    /// <summary>
    /// Получает пользователя по фильтру.<br/>
    /// <strong>Пока не используется.</strong>
    /// </summary>
    /// <param name="filter">Фильтр.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Пользователь, полученный по фильтру.</returns>
    Task<UserDbo?> GetOneUserByFilter(Expression<Func<UserDbo, bool>> filter, CancellationToken cancellationToken = default);

    /// <summary>
    /// Получает все роли по идентификатору пользователя.
    /// </summary>
    /// <param name="userId">Идентификатор пользователя.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Роли пользователя.</returns>
    Task<Roles> GetUserRoles(long userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Получает пользователя по идентификатору.
    /// </summary>
    /// <param name="userId">Идентификатор пользователя.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Пользователь, найденный по идентификатору.</returns>
    Task<UserDbo?> GetUserById(long userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Получает пользователя по юзернейму.
    /// </summary>
    /// <param name="username">Юзернейм пользователя.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Пользователь, найденный по юзернейму.</returns>
    Task<UserDbo?> GetUserByUsername(string username, CancellationToken cancellationToken = default);
}