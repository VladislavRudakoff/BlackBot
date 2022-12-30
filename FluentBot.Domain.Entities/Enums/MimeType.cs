using FluentBot.Domain.Entities.Enums.Abstractions;

namespace FluentBot.Domain.Entities.Enums;

/// <summary>
/// MIME-тип.
/// </summary>
[JsonConverter(typeof(TypesafeEnumConverter<MimeType>))]
public class MimeType : Enumeration
{
    /// <summary>Коллекция ссылок на инстансы с целочисленными ключами.</summary>
    private static readonly Dictionary<int, MimeType> InstancesWithIntegerKeys = new();

    /// <summary>Коллекция ссылок на инстансы со строковыми ключами.</summary>
    private static readonly Dictionary<string, MimeType> InstancesWithStringKeys = new();

    /// <summary>Изображение в формате JPEG.</summary>
    public static readonly MimeType ImageJpeg = new(1, "image/jpeg");

    /// <summary>Изображение в формате GIF.</summary>
    public static readonly MimeType ImageGif = new(2, "image/gif");

    /// <summary>Видео в формате MP4.</summary>
    public static readonly MimeType VideoMp4 = new(3, "video/mp4");

    /// <summary>Текст в формате HTML.</summary>
    public static readonly MimeType TextHtml = new(4, "text/html");

    /// <summary>Содержимое файла в формате PDF.</summary>
    public static readonly MimeType ApplicationPdf = new(5, "application/pdf");

    /// <summary>Содержимое файла в формате ZIP.</summary>
    public static readonly MimeType ApplicationZip = new(6, "application/zip");

    /// <summary>
    /// static ctor.
    /// </summary>
    static MimeType()
    {
        GetInstanceOfEnumeration[typeof(MimeType)] = GetInstance;
    }

    /// <summary>
    /// ctor.
    /// </summary>
    /// <param name="id">Идентификатор перечисления.</param>
    /// <param name="value">Значение перечисления.</param>
    public MimeType(int id, string value) 
        : base(id, value)
    {
        MimeType currentInstance = this;
        InstancesWithIntegerKeys[id] = currentInstance;
        InstancesWithStringKeys[value] = currentInstance;
    }

    /// <summary>
    /// Неявное преобразование числа в перечисление. 
    /// </summary>
    /// <param name="id">Идентификатор значения перечисления.</param>
    public static implicit operator MimeType(int id)
    {
        if (InstancesWithIntegerKeys.TryGetValue(id, out var result))
        {
            return result;
        }

        throw new InvalidCastException($"Cannot implicitly cast {id} to {typeof(MimeType)}");
    }

    /// <summary>
    /// Неявное преобразование строки в перечисление.
    /// </summary>
    /// <param name="value">Значение перечисления.</param>
    public static implicit operator MimeType(string value)
    {
        if (InstancesWithStringKeys.TryGetValue(value, out var result))
        {
            return result;
        }

        throw new InvalidCastException($"Cannot implicitly cast {value} to {typeof(MimeType)}");
    }

    /// <summary>
    /// Возвращает инстанс по ключу(создан как обходной путь для десериализации).
    /// </summary>
    /// <param name="key">Строковый ключ.</param>
    /// <returns>Инстанс соответствующий ключу.</returns>
    private static MimeType GetInstance(string key)
    {
        if (InstancesWithStringKeys.TryGetValue(key, out var result))
        {
            return result;
        }

        throw new NullReferenceException($"The value corresponding to the key '{key}' does not exist.");
    }
}
