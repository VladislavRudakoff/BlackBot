namespace Bot.Logic.Ngrok.Exceptions.NotFound;

/// <summary>
/// Исключение для ненайденных туннелей.
/// </summary>
public class NotFoundTunnelsException : NotFoundException
{
    /// <summary>
    /// ctor.
    /// </summary>
    public NotFoundTunnelsException() 
        : base("Не найдено ни одного открытого туннеля.")
    {
    }
}