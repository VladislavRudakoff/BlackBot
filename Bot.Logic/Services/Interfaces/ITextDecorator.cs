using System.Threading;
using Bot.Data.Enums;

namespace Bot.Logic.Services.Interfaces;

/// <summary>
/// Преобразователь стилей текста.
/// </summary>
public interface ITextDecorator
{
    /// <summary>
    /// Получает стилизованное сообщение.
    /// </summary>
    /// <param name="oldText">Конвертируемый текст.</param>
    /// <param name="textStyle">Требуемый стиль текста.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Стилизованное сообщение.</returns>
    public string ConvertsTextStyle(string oldText, TextSelection textStyle, CancellationToken cancellationToken = default);

    /// <summary>
    /// Получает сообщение с встроенной ссылкой.
    /// </summary>
    /// <param name="oldText">Конвертируемый текст.</param>
    /// <param name="link">Ссылка.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Сообщение с встроенной ссылкой.</returns>
    public string AddingLink(string oldText, string link, CancellationToken cancellationToken = default);

    /// <summary>
    /// Получает сообщение с ссылкой на пользователя.
    /// </summary>
    /// <param name="oldText">Конвертируемый текст.</param>
    /// <param name="userId">Идентификатор пользователя.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Сообщение с ссылкой на пользователя</returns>
    public string AddingMentionUser(string oldText, long userId, CancellationToken cancellationToken = default);
}