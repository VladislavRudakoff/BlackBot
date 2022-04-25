using System;
using System.Threading;
using System.Threading.Tasks;
using Bot.Data.Enums;
using Bot.Logic.Context;
using Bot.Logic.Services.Interfaces;

namespace Bot.Logic.Services;

public class RoleProvider: IRoleProvider
{
    private readonly BotContext context;

    /// <summary>
    /// ctor.
    /// </summary>
    /// <param name="context">Контекст БД.</param>
    public RoleProvider(BotContext context)
    {
        this.context = context;
    }
    public Task<Role> GetAllRoles(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}