using Telegram.Contracts.Exceptions;

namespace Telegram.Contracts.Enums.Abstractions;

/// <summary>
/// Интерфейс для кастомных перечислений.
/// </summary>
public abstract class Enumeration : IComparable
{

    /// <summary>
    /// Идентификатор члена перечисления.
    /// </summary>
    public int Id { get; }

    /// <summary>
    /// Значение члена перечисления.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Коллекция методов для получения инстансов.
    /// </summary>
    public static Dictionary<Type, Func<string, Enumeration>> GetInstanceOfEnumeration { get; private protected set; } = new();

    /// <summary>
    /// ctor.
    /// </summary>
    /// <param name="id">Идентификатор члена перечисления.</param>
    /// <param name="value">Значение члена перечисления.</param>
    protected Enumeration(int id, string value)
    {
        if (id == default) throw new InvalidEnumerationIdentifierException(id);

        (Id, Value) = (id, value);
    }

    /// <summary>
    /// Возвращает строковое представление члена перечисления.
    /// </summary>
    public override string ToString() =>
        Value;

    /// <summary>
    /// Неявное преобразование значения перечисления в число. 
    /// </summary>
    /// <param name="enum">Перечисление.</param>
    public static implicit operator int(Enumeration @enum) =>
        @enum.Id;

    /// <summary>
    /// Неявное преобразование значения перечисления в строку. 
    /// </summary>
    /// <param name="enum">Перечисление.</param>
    public static implicit operator string(Enumeration @enum) =>
        @enum.Value;

    /// <summary>
    /// Метод сравнения, для упорядочения или сортировки.
    /// </summary>
    /// <param name="obj">Экземпляр, сравниваемый с текущим.</param>
    /// <returns>
    /// ○ <b>&lt; 0</b> - текущий экземпляр предшествует объекту переданному в CompareTo метод в порядке сортировки,<br/>
    /// ○ <b>0</b> - текущий экземпляр находится в той же позиции, что и объект переданный в CompareTo метод в порядке сортировки,<br/>
    /// ○ <b>0 &lt;</b> - текущий экземпляр следует после объекта переданного в CompareTo метод в порядке сортировки.
    /// </returns>
    public int CompareTo(object? obj) => 
        Id.CompareTo(((Enumeration)obj!).Id);

    /// <summary>
    /// Сравнивает два экземпляра объекта.
    /// </summary>
    /// <param name="obj">Экземпляр, сравниваемый с текущим.</param>
    public override bool Equals(object? obj)
    {
        if (obj is not Enumeration otherValue)
        {
            return false;
        }

        bool typeMatches = GetType() == obj.GetType();
        bool valueMatchesInt = Id.Equals(otherValue.Id);
        bool valueMatchesString = Value.Equals(otherValue.Value);

        return typeMatches 
               && valueMatchesInt
               && valueMatchesString;
    }

    /// <summary>
    /// Получает хэш-код экземпляра.
    /// </summary>
    /// <returns>Хэш-код.</returns>
    public override int GetHashCode() => 
        HashCode.Combine(Value, Id);
}