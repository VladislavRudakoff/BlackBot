using System.Collections.Generic;

namespace Bot.Data.Models.Files;

public record UserProfilePhotos(
    int TotalCount,
    IEnumerable<IEnumerable<PhotoSize>> Photos);