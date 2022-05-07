using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Bot.Data.Enums;
using Bot.Data.Models;
using Bot.Logic.Context;
using Bot.Logic.Providers.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Bot.Logic.Providers;

public class UserProvider: IUserProvider
{

    private readonly BotContext context;

    /// <summary>
    /// ctor.
    /// </summary>
    /// <param name="context">Контекст БД.</param>
    public UserProvider(BotContext context)
    {
        this.context = context;
    }

    /// <inheritdoc />
    public async Task<IEnumerable<User>> GetAllUsers(CancellationToken cancellationToken = default) => 
        await context.Users.ToListAsync(cancellationToken);

    /// <inheritdoc />
    public async Task<IEnumerable<User>> GetUsersByFilter(Expression<Func<User, bool>> filter, CancellationToken cancellationToken = default) => 
        await context.Users.Where(filter).ToListAsync(cancellationToken);

    /// <inheritdoc />
    public async Task<User?> GetOneUserByFilter(Expression<Func<User, bool>> filter, CancellationToken cancellationToken = default) => 
        await context.Users.SingleOrDefaultAsync(filter, cancellationToken);

    /// <inheritdoc />
    public async Task<Role> GetUserRoles(long userId, CancellationToken cancellationToken = default) =>
        await context.Users
            .Where(x => x.Id == userId)
            .Select(x => x.Role)
            .FirstAsync(cancellationToken);

    /// <inheritdoc />
    public async Task<User?> GetUserById(long userId, CancellationToken cancellationToken = default) => 
        await context.Users.FirstOrDefaultAsync(x => x.Id == userId, cancellationToken);

    public Task<User?> GetUserByUsername(string username, CancellationToken cancellationToken = default) =>
        context.Users
            .Where(x => x.Username == username)
            .FirstOrDefaultAsync(cancellationToken);
}