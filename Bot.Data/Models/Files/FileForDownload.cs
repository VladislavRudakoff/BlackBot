namespace Bot.Data.Models.Files;

/// <summary>
/// 
/// </summary>
/// <param name="FileId"></param>
/// <param name="FileUniqueId"></param>
/// <param name="FileSize"></param>
/// <param name="FilePath"></param>
public record FileForDownload(
    string FileId,
    string FileUniqueId,
    int? FileSize,
    string? FilePath)
    : File(FileId, FileUniqueId);