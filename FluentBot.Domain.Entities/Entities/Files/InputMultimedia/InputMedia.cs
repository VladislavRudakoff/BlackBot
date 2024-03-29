﻿namespace FluentBot.Domain.Entities.Entities.Files.InputMultimedia;

/// <summary>
/// Базовый класс содержимого мультимедийного сообщения.
/// </summary>
/// <param name="Media">Файл для отправки.</param>
/// <param name="Caption">Подпись к отправляемой фотографии(от 0 до 1024 символов).</param>
/// <param name="ParseMode">Форматирование.</param>
/// <param name="CaptionEntities">Список специальных сущностей в заголовке, которые можно указать вместо ParseMode.</param>
public abstract record InputMedia(
    string Media,
    string? Caption,
    string? ParseMode,
    IEnumerable<MessageEntity>? CaptionEntities)
{
    public abstract string Type { get; }
}