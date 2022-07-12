namespace Telegram.Contracts.Exceptions;

/// <summary>
/// Исключение для некорректного идентификатора перечисления.
/// </summary>
public class InvalidEnumerationIdentifierException : ApplicationException
{
    public InvalidEnumerationIdentifierException(int id) 
        : base($"Invalid identifier {id}")
    {
    }
}