using System.Collections.Generic;

namespace Bot.Data.Models.Alerts;

public record VideoChatParticipantsInvited(
    IEnumerable<User> Users);