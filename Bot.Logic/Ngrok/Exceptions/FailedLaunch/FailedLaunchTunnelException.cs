using Bot.Logic.Ngrok.DTOs;
using System;

namespace Bot.Logic.Ngrok.Exceptions.FailedLaunch;

/// <summary>
/// Исключение при неудачном запуске туннеля.
/// </summary>
public class FailedLaunchTunnelException : ApplicationException
{
    /// <summary>
    /// ctor.
    /// </summary>
    /// <param name="startTunnel">Модель с информацией о запускаемом туннеле.</param>
    public FailedLaunchTunnelException(StartTunnel startTunnel) 
        : base("Неудачный запуск туннеля. " +
               "Конфигурация: " +
               $"- Адрес: {startTunnel.Addr}.{Environment.NewLine}" +
               $"- Протокол: {startTunnel.Proto}" +
               $"- Имя: {startTunnel.Name}")
    {
    }
}