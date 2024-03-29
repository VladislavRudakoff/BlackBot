﻿namespace FluentBot.Domain.UseCases.Events.Chats.Messages;

/// <summary>
/// Модель для удаления всех сообщений из списка закрепленных.
/// </summary>
/// <param name="ChatId"></param>
public record UnpinAllChatMessages(
    ChatId ChatId)
    : IEventEntity;