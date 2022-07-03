using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Chats.Commands.Stickers;

/// <summary>
/// Модель для удаления набора стикеров.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
public record DeleteChatStickerSet(
    ChatId ChatId)
    : IEventEntity;