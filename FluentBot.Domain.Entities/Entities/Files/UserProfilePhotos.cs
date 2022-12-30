namespace FluentBot.Domain.Entities.Entities.Files;

public record UserProfilePhotos(
    int TotalCount,
    IEnumerable<IEnumerable<PhotoSize>> Photos);