using Telegram.Contracts.Enums.

namespace Telegram.Contracts.DTOs.Keyboard;

/// <summary>
/// Кнопка настраиваемой клавиатуры. Свойства RequestContact, RequestLocation и RequestPool являются взаимоисключающими.
/// </summary>
/// <param name="Text">Текст кнопки. Если ни одно из необязательных полей не используется, оно будет отправлено в виде сообщения при нажатии кнопки.</param>
/// <param name="RequestContact">Если true, то будет отправлен номер телефона пользователя. <b>Доступно только в приватных чатах.</b></param>
/// <param name="RequestLocation">Если true, то будет отправлено текущее местонахождение пользователя. <b>Доступно только в приватных чатах.</b></param>
/// <param name="RequestPool">Если указано, пользователю будет предложено создать опрос и отправить его боту. <b>Доступно только в приватных чатах.</b></param>
public record KeyboardButton(
    string Text,
    bool? RequestContact,
    bool? RequestLocation,
    PollType? RequestPool);