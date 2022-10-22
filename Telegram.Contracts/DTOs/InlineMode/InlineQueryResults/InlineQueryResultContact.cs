using Telegram.Contracts.DTOs.InlineMode.ContentOfInputMessages;
using Telegram.Contracts.DTOs.Keyboard;
using Telegram.Contracts.Enums;

namespace Telegram.Contracts.DTOs.InlineMode.InlineQueryResults;

/// <summary>
/// Представляет контакт с номером телефона.
/// </summary>
/// <param name="Id">Идентификатор результата(1-64 байта).</param>
/// <param name="PhoneNumber">Телефонный номер контакта.</param>
/// <param name="FirstName">Имя контакта.</param>
/// <param name="LastName">Фамилия контакта.</param>
/// <param name="Vcard">Дополнительные данные о контакте в виде vCard(0-2048 байт).</param>
/// <param name="ReplyMarkup">Встроенная клавиатура.</param>
/// <param name="InputMessageContent">Содержание сообщения, которое будет отправлено вместо контакта.</param>
/// <param name="ThumbUrl">URL миниатюры.</param>
/// <param name="ThumbWidth">Ширина миниатюры.</param>
/// <param name="ThumbHeight">Высота миниатюры.</param>
public record InlineQueryResultContact(
    string Id,
    string PhoneNumber,
    string FirstName,
    string? LastName,
    string? Vcard,
    InlineKeyboardMarkup? ReplyMarkup,
    InputMessageContent? InputMessageContent,
    string? ThumbUrl,
    string? ThumbWidth,
    string? ThumbHeight)
    : InlineQueryResult(Id)
{
    protected override InlineQueryResultType Type => InlineQueryResultType.Contact;
}