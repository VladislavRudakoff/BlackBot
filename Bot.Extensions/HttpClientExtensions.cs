using System.Text;
using Bot.Common.Extensions.Settings;
using Newtonsoft.Json;

namespace Bot.Common.Extensions;

/// <summary>
/// Расширения для <see cref="HttpClient"/>.
/// </summary>
public static class HttpClientExtensions
{
    /// <summary>
    /// Асинхронно возвращает Json-ответ на GET запрос.
    /// </summary>
    /// <typeparam name="T">Запрашиваемый объект.</typeparam>
    /// <param name="client"><see cref="HttpClient"/>.</param>
    /// <param name="url">Url на который идёт запрос.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Json-ответ.</returns>
    public static async Task<T?> GetAsJsonAsync<T>(this HttpClient client, string url, CancellationToken cancellationToken = default)
    {
        HttpResponseMessage response = await client.GetAsync(url, cancellationToken);

        return await DeserializeResponse<T>(response, cancellationToken);
    }

    /// <summary>
    /// Асинхронно возвращает Json-ответ на Post запрос.
    /// </summary>
    /// <typeparam name="T">Запрашиваемый объект.</typeparam>
    /// <param name="client"><see cref="HttpClient"/>.</param>
    /// <param name="url">Url на который идёт запрос.</param>
    /// <param name="body">Модель тела запроса.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Json-ответ.</returns>
    public static async Task<T?> PostAsJsonAsync<T>(this HttpClient client, string url, object body, CancellationToken cancellationToken = default)
    {
        HttpResponseMessage response = 
            await client.PostAsync(
                url,
                SerializeRequest(body), 
                cancellationToken);

        return await DeserializeResponse<T>(response, cancellationToken);
    }

    /// <summary>
    /// Десериализует ответ.
    /// </summary>
    /// <typeparam name="TResponse">Десериализуемый объект.</typeparam>
    /// <param name="response">Ответ.</param>
    /// <param name="cancellationToken">Маркер отмены.</param>
    /// <returns>Десериализованный ответ.</returns>
    private static async Task<TResponse> DeserializeResponse<TResponse>(HttpResponseMessage response, CancellationToken cancellationToken = default)
    {
        response.EnsureSuccessStatusCode();

        string responseContent = await response.Content.ReadAsStringAsync(cancellationToken);

        return JsonConvert.DeserializeObject<TResponse>(responseContent, SerializerSettings.SnakeCaseSerializerOptions)!;
    }

    /// <summary>
    /// Сериализует запрос.
    /// </summary>
    /// <param name="request">Запрос.</param>
    /// <returns>Сериализованный запрос.</returns>
    private static StringContent SerializeRequest(object request) => 
        new(
            JsonConvert.SerializeObject(
                request, 
                SerializerSettings.SnakeCaseSerializerOptions), 
            Encoding.UTF8, 
            "application/json");
}