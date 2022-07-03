using Bot.Data.DboModels;
using Microsoft.EntityFrameworkCore;

namespace Bot.Data.AppContext;

public class BotContext: DbContext
{
    /// <summary>
    /// Пользователи.
    /// </summary>
    public DbSet<UserDbo> Users { get; set; } = null!;

    public BotContext(DbContextOptions<BotContext> options)
        :base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserDbo>(u =>
        {
            u.Property(p => p.Id).UseIdentityAlwaysColumn().IsRequired();

            u.HasKey(k => k.Id);

            u.HasIndex(i => i.Id);

            u.HasIndex(i => i.Username);

            u.HasIndex(i => new { i.Id, i.Username});
        });
    }
}