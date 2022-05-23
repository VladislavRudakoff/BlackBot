namespace Telegram.Contracts.DTOs.Files;

/// <summary>
/// Контакт.
/// </summary>
/// <param name="PhoneNumber">Телефонный номер.</param>
/// <param name="FirstName">Имя контакта.</param>
/// <param name="LastName">Фамилия контакта.</param>
/// <param name="UserId">Идентификатор пользователя.</param>
public record Contact(
    string PhoneNumber,
    string FirstName,
    string? LastName,
    long? UserId);