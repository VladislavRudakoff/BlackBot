namespace Bot.Common.Extensions;

/// <summary>
/// Класс с методами расширения для <see cref="object"/>.
/// </summary>
public static class ObjectExtensions
{
    /// <summary>
    /// Проверяет объект на null.
    /// </summary>
    /// <typeparam name="T">Проверяемый объект.</typeparam>
    /// <param name="value">Значение для проверки.</param>
    /// <param name="parameterName">Имя объекта.</param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"><see cref="ArgumentNullException"/>.</exception>
    public static T ThrowIfNull<T>(this T? value, string parameterName) =>
        value ?? throw new ArgumentNullException(parameterName);
}