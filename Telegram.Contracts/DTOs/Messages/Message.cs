using Telegram.Contracts.DTOs.Chats;

namespace Telegram.Contracts.DTOs.Messages;

public record Message(
    int MessageId, 
    User? From, 
    Chat? SenderChat, 
    int Date, 
    User? ForwardFrom, 
    Chat Chat, 
    Chat? ForwardFromChat, 
    int? ForwardFromMessageId, 
    string? ForwardSignature, 
    string? ForwardSenderName, 
    int? ForwardDate, 
    bool? IsAutomaticForward, 
    Message? ReplyToMessage, 
    User? ViaBot, 
    int? EditDate, 
    bool? HasProtectedContent, 
    string? MediaGroupId, 
    string? AuthorSignature, 
    string? Text, 
    IEnumerable<MessageEntity> Entities);