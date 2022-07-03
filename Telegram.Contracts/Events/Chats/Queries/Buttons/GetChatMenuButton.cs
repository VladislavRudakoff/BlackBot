using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Chats.Queries.Buttons;

/// <summary>
/// Модель для получения текущего значения кнопки меню бота в приватном чате или кнопки меню по умолчанию.
/// </summary>
/// <param name="ChatId">Идентификатор чата(если null - будет возвращена кнопка меню бота по умолчанию).</param>
public record GetChatMenuButton(
    ChatId? ChatId)
    : IEventEntity;