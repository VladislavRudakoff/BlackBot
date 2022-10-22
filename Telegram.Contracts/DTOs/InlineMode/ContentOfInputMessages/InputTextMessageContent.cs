using Telegram.Contracts.DTOs.Messages;

namespace Telegram.Contracts.DTOs.InlineMode.ContentOfInputMessages;

/// <summary>
/// Представляет содержимое текстового сообщения, которое отправлено в результате inline-запроса.
/// </summary>
/// <param name="MessageText">Текст сообщения(1-4096 символов).</param>
/// <param name="ParseMode">Форматирование.</param>
/// <param name="Entities">Специальные сущности.</param>
/// <param name="DisableWebPagePreview">True - отключает предварительный просмотр ссылок в сообщении.</param>
public record InputTextMessageContent(
    string MessageText,
    string? ParseMode,
    IEnumerable<MessageEntity>? Entities,
    bool? DisableWebPagePreview)
    : InputMessageContent;