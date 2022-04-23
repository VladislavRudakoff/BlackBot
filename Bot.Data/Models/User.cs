using Bot.Data.Enums;

namespace Bot.Data.Models
{
    /// <summary>
    /// Пользователь.
    /// </summary>
    public record User(int Id, string FullName, string ShortName, Role Role);
}
