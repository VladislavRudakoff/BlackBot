namespace Bot.Logic.Ngrok.Exceptions.NotFound;

/// <summary>
/// Исключение для ненайденной информации о туннеле.
/// </summary>
public class NotFoundTunnelDetailException : NotFoundException
{
    /// <summary>
    /// ctor.
    /// </summary>
    /// <param name="tunnelName">Имя туннеля.</param>
    public NotFoundTunnelDetailException(string tunnelName) 
        : base($"Не найдена информация о туннеле с именем: {tunnelName}")
    {
    }
}