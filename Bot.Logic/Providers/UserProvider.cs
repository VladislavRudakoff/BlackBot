using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Bot.Data.Enums;
using Bot.Data.Models;
using Bot.Logic.AppContext;
using Bot.Logic.Providers.Interfaces;
using Bot.Logic.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Polly;
using Polly.Caching;

namespace Bot.Logic.Providers;

public class UserProvider: IUserProvider
{

    private readonly BotContext context;
    private readonly AsyncCachePolicy<IEnumerable<User>> usersCache;
    private readonly AsyncCachePolicy<Roles> userRolesCache;

    /// <summary>
    /// ctor.
    /// </summary>
    /// <param name="context">Контекст БД.</param>
    /// <param name="policyFactory"><see cref="ICachingPolicyFactory"/>.</param>
    public UserProvider(
        BotContext context, 
        ICachingPolicyFactory policyFactory)
    {
        this.context = context;

        usersCache = policyFactory.CreateAsyncCachePolicy<IEnumerable<User>>();
        userRolesCache = policyFactory.CreateAsyncCachePolicy<Roles>();
    }

    /// <inheritdoc />
    public async Task<IEnumerable<User>> GetAllUsers(CancellationToken cancellationToken = default) =>
        await usersCache.ExecuteAsync(async (_, ct) =>
                await context.Users.ToListAsync(cancellationToken),
                new Context("all_users"),
                cancellationToken);

    /// <inheritdoc />
    public async Task<IEnumerable<User>> GetUsersByFilter(Expression<Func<User, bool>> filter, CancellationToken cancellationToken = default) => 
        await context.Users.Where(filter).ToListAsync(cancellationToken);

    /// <inheritdoc />
    public async Task<User?> GetOneUserByFilter(Expression<Func<User, bool>> filter, CancellationToken cancellationToken = default) => 
        await context.Users.SingleOrDefaultAsync(filter, cancellationToken);

    /// <inheritdoc />
    public async Task<Roles> GetUserRoles(long userId, CancellationToken cancellationToken = default) =>
        await userRolesCache.ExecuteAsync(async (_, ct) => 
            await context.Users
            .Where(x => x.Id == userId)
            .Select(x => x.Role)
            .FirstAsync(cancellationToken),
            new Context($"user-{userId}_roles"),
            cancellationToken);

    /// <inheritdoc />
    public async Task<User?> GetUserById(long userId, CancellationToken cancellationToken = default) => 
        await context.Users.FirstOrDefaultAsync(x => x.Id == userId, cancellationToken);

    /// <inheritdoc />
    public Task<User?> GetUserByUsername(string username, CancellationToken cancellationToken = default) =>
        context.Users
            .Where(x => x.Username == username)
            .FirstOrDefaultAsync(cancellationToken);
}