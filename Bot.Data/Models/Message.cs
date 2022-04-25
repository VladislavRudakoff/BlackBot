using System;

namespace Bot.Data.Models;

/// <summary>
/// Модель сообщения.
/// </summary>
/// <param name="UserId">Идентификатор пользователя, который отправил сообщение.</param>
/// <param name="Text">Текст сообщения.</param>
/// <param name="SendingTime">Время отправки сообщения.</param>
public record Message(long UserId, int Text, DateTime SendingTime);