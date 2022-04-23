namespace Bot.Data.Models
{
    /// <summary>
    /// Авторизованный пользователь.
    /// </summary>
    /// <param name="Id">Идентификатор пользователя.</param>
    /// <param name="Name">Имя пользователя.</param>
    /// <param name="Username">Юзернейм пользователя.</param>
    public record AuthorizedUser(long Id, string Name, string Username);
}
