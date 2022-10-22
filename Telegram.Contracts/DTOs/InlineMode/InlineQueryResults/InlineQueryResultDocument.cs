using Telegram.Contracts.DTOs.InlineMode.ContentOfInputMessages;
using Telegram.Contracts.DTOs.Keyboard;
using Telegram.Contracts.DTOs.Messages;
using Telegram.Contracts.Enums;
using Telegram.Contracts.Enums.Abstractions;

namespace Telegram.Contracts.DTOs.InlineMode.InlineQueryResults;

/// <summary>
/// Представляет ссылку на файл.
/// </summary>
public record InlineQueryResultDocument : InlineQueryResult
{
    private readonly MimeType mimeType = null!;

    /// <summary>
    /// Представляет ссылку на файл.
    /// </summary>
    /// <param name="id">Идентификатор результата(1-64 байта).</param>
    /// <param name="title">Заголовок.</param>
    /// <param name="documentUrl">URL-адрес файла.</param>
    /// <param name="caption">Подпись отправляемого файла(0-1024 символа).</param>
    /// <param name="parseMode">Форматирование.</param>
    /// <param name="captionEntities">Специальные сущности в заголовке.</param>
    /// <param name="mimeType">MIME-тип содержимого файла.</param>
    /// <param name="description">Описание.</param>
    /// <param name="thumbUrl">URL миниатюры(JPEG).</param>
    /// <param name="thumbWidth">Ширина миниатюры.</param>
    /// <param name="thumbHeight">Высота миниатюры.</param>
    /// <param name="replyMarkup">Встроенная клавиатура.</param>
    /// <param name="inputMessageContent">Содержание сообщения, которое будет отправлено вместо файла.</param>
    public InlineQueryResultDocument(
        string id,
        string title,
        string documentUrl,
        string? caption,
        string? parseMode,
        IEnumerable<MessageEntity>? captionEntities,
        MimeType mimeType,
        string? description,
        string? thumbUrl,
        int? thumbWidth,
        int? thumbHeight,
        InlineKeyboardMarkup? replyMarkup,
        InputMessageContent? inputMessageContent) : base(id)
    {
        Title = title;
        DocumentUrl = documentUrl;
        Caption = caption;
        ParseMode = parseMode;
        CaptionEntities = captionEntities;
        Description = description;
        ThumbUrl = thumbUrl;
        ThumbWidth = thumbWidth;
        ThumbHeight = thumbHeight;
        ReplyMarkup = replyMarkup;
        InputMessageContent = inputMessageContent;
        MimeType = mimeType;
    }

    /// <summary>Заголовок.</summary>
    public string Title { get; init; }

    /// <summary>URL-адрес файла.</summary>
    public string DocumentUrl { get; init; }

    /// <summary>Подпись отправляемого файла(0-1024 символа).</summary>
    public string? Caption { get; init; }

    /// <summary>Форматирование.</summary>
    public string? ParseMode { get; init; }

    /// <summary>Специальные сущности в заголовке.</summary>
    public IEnumerable<MessageEntity>? CaptionEntities { get; init; }

    /// <summary>Описание.</summary>
    public string? Description { get; init; }

    /// <summary>URL миниатюры(JPEG).</summary>
    public string? ThumbUrl { get; init; }

    /// <summary>Ширина миниатюры.</summary>
    public int? ThumbWidth { get; init; }

    /// <summary>Высота миниатюры.</summary>
    public int? ThumbHeight { get; init; }

    /// <summary>Встроенная клавиатура.</summary>
    public InlineKeyboardMarkup? ReplyMarkup { get; init; }

    /// <summary>Содержание сообщения, которое будет отправлено вместо файла.</summary>
    public InputMessageContent? InputMessageContent { get; init; }

    //TODO: Заменить такие проверки на что-то более цивильное.
    /// <summary>MIME-тип содержимого файла.</summary>
    public MimeType MimeType
    {
        get => mimeType;

        init
        {
            MimeType type = (MimeType)Enumeration.GetInstanceOfEnumeration[typeof(MimeType)](value.Value);

            mimeType = (type.Equals(MimeType.ApplicationZip) || type.Equals(MimeType.ApplicationPdf)) switch
            {
                true => mimeType = value,
                _ => throw new InvalidCastException()
            };
        }
    }

    /// <summary>Тип результата.</summary>
    protected override InlineQueryResultType Type => InlineQueryResultType.Document;

    /// <summary>
    /// deconstruct.
    /// </summary>
    /// <param name="id">Идентификатор результата(1-64 байта).</param>
    /// <param name="title">Заголовок.</param>
    /// <param name="documentUrl">URL-адрес файла.</param>
    /// <param name="caption">Подпись отправляемого файла(0-1024 символа).</param>
    /// <param name="parseMode">Форматирование.</param>
    /// <param name="captionEntities">Специальные сущности в заголовке.</param>
    /// <param name="description">Описание.</param>
    /// <param name="thumbUrl">URL миниатюры(JPEG).</param>
    /// <param name="thumbWidth">Ширина миниатюры.</param>
    /// <param name="thumbHeight">Высота миниатюры.</param>
    /// <param name="replyMarkup">Встроенная клавиатура.</param>
    /// <param name="inputMessageContent">Содержание сообщения, которое будет отправлено вместо файла.</param>
    public void Deconstruct(
        out string id,
        out string title,
        out string documentUrl,
        out string? caption,
        out string? parseMode,
        out IEnumerable<MessageEntity>? captionEntities,
        out string? description,
        out string? thumbUrl,
        out int? thumbWidth,
        out int? thumbHeight,
        out InlineKeyboardMarkup? replyMarkup,
        out InputMessageContent? inputMessageContent)
    {
        id = Id;
        title = Title;
        documentUrl = DocumentUrl;
        caption = Caption;
        parseMode = ParseMode;
        captionEntities = CaptionEntities;
        description = Description;
        thumbUrl = ThumbUrl;
        thumbWidth = ThumbWidth;
        thumbHeight = ThumbHeight;
        replyMarkup = ReplyMarkup;
        inputMessageContent = InputMessageContent;
    }
}