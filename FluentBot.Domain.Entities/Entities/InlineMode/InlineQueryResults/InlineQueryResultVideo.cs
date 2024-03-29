﻿using FluentBot.Domain.Entities.Entities.InlineMode.ContentOfInputMessages;

namespace FluentBot.Domain.Entities.Entities.InlineMode.InlineQueryResults;

/// <summary>
/// Представляет ссылку на страницу, содержащую встроенный видеопроигрыватель или видеофайл.
/// </summary>
/// <param name="Id">Идентификатор результата(1-64 байта).</param>
/// <param name="VideoUrl">Действительный URL-адрес встроенный видеопроигрывателя или видеофайла.</param>
/// <param name="ThumbUrl">URL миниатюры (JPEG).</param>
/// <param name="MimeType">MIME-тип содержимого.</param>
/// <param name="Title">Заголовок.</param>
/// <param name="Caption">Подпись отправляемого файла(0-1024 символа).</param>
/// <param name="ParseMode">Форматирование.</param>
/// <param name="CaptionEntities">Специальные сущности в заголовке.</param>
/// <param name="VideoWidth">Ширина видео.</param>
/// <param name="VideoHeight">Высота видео.</param>
/// <param name="VideoDuration">Длительность видео в секундах.</param>
/// <param name="Description">Описание.</param>
/// <param name="ReplyMarkup">Встроенная клавиатура.</param>
/// <param name="InputMessageContent">Содержание сообщения, которое будет отправлено вместо видео.</param>
public record InlineQueryResultVideo(
    string Id,
    string VideoUrl,
    string ThumbUrl,
    string MimeType,
    string? Title,
    string? Caption,
    string? ParseMode,
    IEnumerable<MessageEntity>? CaptionEntities,
    int? VideoWidth,
    int? VideoHeight,
    int? VideoDuration,
    string? Description,
    InlineKeyboardMarkup? ReplyMarkup,
    InputMessageContent? InputMessageContent)
    : InlineQueryResult(Id)
{
    protected override InlineQueryResultType Type => InlineQueryResultType.Video;
}