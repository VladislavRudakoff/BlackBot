using System;

namespace Bot.Logic.Exceptions;

public class TextConversionException: Exception
{
    public TextConversionException() 
        : base("Не удалось сконвертировать текст.")
    {
    }
}
