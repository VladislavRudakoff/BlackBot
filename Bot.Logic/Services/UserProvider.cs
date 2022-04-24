using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Bot.Data.Enums;
using Bot.Data.Models;
using Bot.Logic.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Bot.Logic.Services
{
    public class UserProvider: IUserProvider
    {

        private readonly DbContext context;

        /// <summary>
        /// ctor.
        /// </summary>
        /// <param name="context">Контекст БД.</param>
        public UserProvider(DbContext context)
        {
            this.context = context;
        }

        public Task<IEnumerable<User>> GetAllUsers(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetUsersByFilter(Expression<Func<User, bool>> filter, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetOneUserByFilter(Expression<Func<User, bool>> filter, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<Role> GetUserRoles(Expression<Func<User, bool>> filter, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserById(long userId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}