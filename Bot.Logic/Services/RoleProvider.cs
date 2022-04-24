using System;
using System.Threading;
using System.Threading.Tasks;
using Bot.Data.Enums;
using Bot.Logic.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Bot.Logic.Services
{
    public class RoleProvider: IRoleProvider
    {
        private readonly DbContext context;

        /// <summary>
        /// ctor.
        /// </summary>
        /// <param name="context">Контекст БД.</param>
        public RoleProvider(DbContext context)
        {
            this.context = context;
        }
        public Task<Role> GetAllRoles(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}