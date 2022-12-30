
namespace FluentBot.Domain.Entities.Entities.Alerts;

public record VideoChatParticipantsInvited(
    IEnumerable<User> Users);