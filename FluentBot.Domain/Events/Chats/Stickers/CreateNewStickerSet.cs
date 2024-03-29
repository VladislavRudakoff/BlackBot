﻿
//using Telegram.Contracts.Events.Interfaces;

//namespace Telegram.Contracts.Events.Chats.Commands.Stickers;


//TODO: Разобраться с InputFile(multipart/form-data).
///// <summary>
///// Модель для создания набора стикеров.
///// </summary>
///// <param name="UserId">Идентификатор создателя набора стикеров.</param>
///// <param name="Name">Название набора стикеров(1-64 символа), для использования в <i>t.me/addstickers/{stickerSetName}_by_{bot_username}</i>.<br />
///// {bot_username} не чувствителен к регистру</param>
///// <param name="Title">Название набора стикеров(1-64 символа).</param>
///// <param name="PngSticker">Статический стикер(PNG).<br />
///// Если использовать тут FileId, то отправится файл, который уже есть на сервере телеграма.<br />
///// Если использовать Url-адрес HTTP, телеграм получит файл из интернета.<br />
///// Также можно загрузить новый файл, с помощью <i>multipart/form-data</i>.</param>
///// <param name="TgsSticker">Анимированный стикер(TGS). Загружается только с помощью <i>multipart/form-data</i>.</param>
///// <param name="WebmSticker">Видеостикер(WEBM). Загружается только с помощью <i>multipart/form-data</i>.</param>
///// <param name="Emojis">Один или несколько смайликов, соответствующих стикерам.</param>
///// <param name="ContainsMasks">True - если необходимо создать набор стикеров-масок.</param>
///// <param name="MaskPosition">Положение маски.</param>
//public record CreateNewStickerSet(
//    long UserId,
//    string Name,
//    string Title,
//    string? PngSticker,
//    InputFile? TgsSticker,
//    InputFile? WebmSticker,
//    string Emojis,
//    bool? ContainsMasks,
//    MaskPosition? MaskPosition)
//    : IEventEntity;