﻿namespace FluentBot.Domain.Entities.Entities.Files;

/// <summary>
/// Базовая модель любого файла.
/// </summary>
/// <param name="FileId">Идентификатор файла, который может быть использован для загрузки или повторного использования файла.</param>
/// <param name="FileUniqueId">Уникальный идентификатор файла, который должен быть одинаковым в течение долгого времени и для разных ботов.<br/>
/// <b>Не может быть использован для загрузки или повторного использования файла.</b></param>
public record File(
    string FileId,
    string FileUniqueId);