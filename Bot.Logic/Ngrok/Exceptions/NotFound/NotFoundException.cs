using System;

namespace Bot.Logic.Ngrok.Exceptions.NotFound;

/// <summary>
/// Исключение для ненайденных сущностей.
/// </summary>
public class NotFoundException : ApplicationException
{
    /// <summary>
    /// ctor.
    /// </summary>
    /// <param name="exceptionText">Текст исключения.</param>
    public NotFoundException(string exceptionText)
        : base(exceptionText)
    {
    }
}