using Newtonsoft.Json;
using Telegram.Contracts.Converters;
using Telegram.Contracts.Enums.Abstractions;

namespace Telegram.Contracts.Enums;

/// <summary>
/// Тип результата.
/// </summary>
[JsonConverter(typeof(InlineQueryResultTypeConverter))]
public sealed class InlineQueryResultType : Enumeration
{
    /// <summary>Коллекция ссылок на инстансы с целочисленными ключами.</summary>
    private static readonly Dictionary<int, InlineQueryResultType> InstancesWithIntegerKeys = new();

    /// <summary>Коллекция ссылок на инстансы со строковыми ключами.</summary>
    private static readonly Dictionary<string, InlineQueryResultType> InstancesWithStringKeys = new();

    /// <summary>Статья.</summary>
    public static readonly InlineQueryResultType Article = new(1, "article");

    /// <summary>Фотография.</summary>
    public static readonly InlineQueryResultType Photo = new(2, "photo");

    /// <summary>Анимация.</summary>
    public static readonly InlineQueryResultType Gif = new(3, "gif");

    /// <summary>Видео-анимация.</summary>
    public static readonly InlineQueryResultType VideoAnimation = new(4, "mpeg4_gif");

    /// <summary>Видео.</summary>
    public static readonly InlineQueryResultType Video = new(5, "video");

    /// <summary>Аудио.</summary>
    public static readonly InlineQueryResultType Audio = new(6, "audio");

    /// <summary>Голосовое сообщение.</summary>
    public static readonly InlineQueryResultType Voice = new(7, "voice");

    /// <summary>Документ.</summary>
    public static readonly InlineQueryResultType Document = new(8, "document");

    /// <summary>Местоположение.</summary>
    public static readonly InlineQueryResultType Location = new(9, "location");

    /// <summary>Место проведения.</summary>
    public static readonly InlineQueryResultType Venue = new(10, "venue");

    /// <summary>Контакт.</summary>
    public static readonly InlineQueryResultType Contact = new(11, "contact");

    /// <summary>Стикер.</summary>
    public static readonly InlineQueryResultType Sticker = new(12, "sticker");

    /// <summary>
    /// static ctor.
    /// </summary>
    static InlineQueryResultType()
    {
        Instance = GetInstance;
    }

    /// <summary>
    /// ctor.
    /// </summary>
    /// <param name="id">Идентификатор перечисления.</param>
    /// <param name="value">Значение перечисления.</param>
    private InlineQueryResultType(int id, string value)
        : base(id, value)
    {
        InlineQueryResultType currentInstance = this;
        InstancesWithIntegerKeys[id] = currentInstance;
        InstancesWithStringKeys[value] = currentInstance;
    }

    /// <summary>
    /// Неявное преобразование числа в перечисление. 
    /// </summary>
    /// <param name="id">Идентификатор значения перечисления.</param>
    public static implicit operator InlineQueryResultType(int id)
    {
        if (InstancesWithIntegerKeys.TryGetValue(id, out var result))
        {
            return result;
        }

        throw new InvalidCastException($"Cannot implicitly cast {id} to {typeof(InlineQueryResultType)}");
    }

    /// <summary>
    /// Неявное преобразование строки в перечисление.
    /// </summary>
    /// <param name="value">Значение перечисления.</param>
    public static implicit operator InlineQueryResultType(string value)
    {
        if (InstancesWithStringKeys.TryGetValue(value, out var result))
        {
            return result;
        }

        throw new InvalidCastException($"Cannot implicitly cast {value} to {typeof(InlineQueryResultType)}");
    }

    /// <summary>
    /// Возвращает инстанс по ключу(создан как обходной путь для десериализации).
    /// </summary>
    /// <param name="key">Строковый ключ.</param>
    /// <returns>Инстанс соответствующий ключу.</returns>
    private static InlineQueryResultType GetInstance(string key)
    {
        if (InstancesWithStringKeys.TryGetValue(key, out var result))
        {
            return result;
        }

        throw new NullReferenceException($"The value corresponding to the key '{key}' does not exist.");
    }
}