using Bot.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Bot.Logic.Context
{
    public class BotContext: DbContext
    {
        public DbSet<User> Users { get; set; } = null!;

        /// <summary>
        /// ctor.
        /// </summary>
        public BotContext()
        {
        }
    }
}