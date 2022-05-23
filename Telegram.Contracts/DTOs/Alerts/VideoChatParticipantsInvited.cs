
namespace Telegram.Contracts.DTOs.Alerts;

public record VideoChatParticipantsInvited(
    IEnumerable<User> Users);