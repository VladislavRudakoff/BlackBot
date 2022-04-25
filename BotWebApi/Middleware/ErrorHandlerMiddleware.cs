using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using Bot.Logic.Exceptions;
using Microsoft.AspNetCore.Http;

namespace Bot.WebApi.Middleware;

/// <summary>
/// Middleware для отлова исключений.
/// </summary>
public class ErrorHandlerMiddleware
{
    private readonly RequestDelegate next;

    public ErrorHandlerMiddleware(RequestDelegate next)
    {
        this.next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await next(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionMessageAsync(context, ex);
        }
    }

    private static Task HandleExceptionMessageAsync(HttpContext context, Exception exception)
    {
        context.Response.ContentType = "application/json";

        if (exception is TextConversionException)
        {
            context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
        }

        var result = JsonSerializer.Serialize(new { message = exception.Message });

        return context.Response.WriteAsync(result);
    }
}