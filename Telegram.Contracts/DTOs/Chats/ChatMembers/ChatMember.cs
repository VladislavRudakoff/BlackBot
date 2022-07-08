using JsonSubTypes;
using Newtonsoft.Json;

namespace Telegram.Contracts.DTOs.Chats.ChatMembers;

/// <summary>
/// Участник чата.
/// </summary>
[JsonConverter(typeof(JsonSubtypes), nameof(Status))]
[JsonSubtypes.KnownSubType(typeof(ChatMemberAdministrator), "administrator")]
[JsonSubtypes.KnownSubType(typeof(ChatMemberBanned), "kicked")]
[JsonSubtypes.KnownSubType(typeof(ChatMemberLeft), "left")]
[JsonSubtypes.KnownSubType(typeof(ChatMemberOwner), "creator")]
[JsonSubtypes.KnownSubType(typeof(ChatMemberRegular), "member")]
[JsonSubtypes.KnownSubType(typeof(ChatMemberRestricted), "restricted")]
public abstract record ChatMember
{
    /// <summary>
    /// Статус участника чата.
    /// </summary>
    protected abstract string Status { get; }
}