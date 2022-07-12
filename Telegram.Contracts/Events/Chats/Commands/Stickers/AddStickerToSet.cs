//using Telegram.Contracts.DTOs.Stickers;
//using Telegram.Contracts.Events.Interfaces;

//namespace Telegram.Contracts.Events.Chats.Commands.Stickers;

//TODO: Разобраться с InputFile(multipart/form-data).
///// <summary>
///// Модель для добавления стикера к набору.
///// </summary>
///// <param name="UserId">Идентификатор создателя набора стикеров.</param>
///// <param name="Name">Название набора стикеров(1-64 символа), для использования в <i>t.me/addstickers/{stickerSetName}_by_{bot_username}</i>.<br />
///// {bot_username} не чувствителен к регистру</param>
///// <param name="PngSticker">Статический стикер(PNG).<br />
///// Если использовать тут FileId, то отправится файл, который уже есть на сервере телеграма.<br />
///// Если использовать Url-адрес HTTP, телеграм получит файл из интернета.<br />
///// Также можно загрузить новый файл, с помощью <i>multipart/form-data</i>.</param>
///// <param name="TgsSticker">Анимированный стикер(TGS). Загружается только с помощью <i>multipart/form-data</i>.</param>
///// <param name="WebmSticker">Видеостикер(WEBM). Загружается только с помощью <i>multipart/form-data</i>.</param>
///// <param name="Emojis">Один или несколько смайликов, соответствующих стикерам.</param>
///// <param name="MaskPosition">Положение маски.</param>
//public record AddStickerToSet(
//    long UserId,
//    string Name,
//    string? PngSticker,
//    InputFile? TgsSticker,
//    InputFile? WebmSticker,
//    string Emojis,
//    MaskPosition? MaskPosition)
//    : IEventEntity;