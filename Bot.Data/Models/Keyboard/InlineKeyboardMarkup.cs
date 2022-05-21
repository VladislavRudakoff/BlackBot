using System.Collections.Generic;

namespace Bot.Data.Models.Keyboard;

/// <summary>
/// Встроенная клавиатура, которая появляется рядом с сообщением, которому она принадлежит.
/// </summary>
/// <param name="InlineKeyboard">Коллекция кнопок.</param>
public record InlineKeyboardMarkup(
    IEnumerable<IEnumerable<InlineKeyboardButton>> InlineKeyboard);