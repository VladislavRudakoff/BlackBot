using System.Collections.Generic;

namespace Telegram.Contracts.DTOs.Files;

public record UserProfilePhotos(
    int TotalCount,
    IEnumerable<IEnumerable<PhotoSize>> Photos);