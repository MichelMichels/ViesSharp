using MichelMichels.ViesSharp.Exceptions;
using MichelMichels.ViesSharp.Models;
using System.Net.Http.Json;

namespace MichelMichels.ViesSharp;

public class ViesSharpClient(ViesSharpOptions? options = null) : IViesSharpClient
{
    private readonly ViesSharpOptions options = options ?? new ViesSharpOptions();

    private HttpClient? _httpClient;

    /// <summary>
    /// Wrapper method for POST request /check-vat-number
    /// API docs: Check a Vat Number for a specific country
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<VatNumberResponse> CheckVatNumber(VatNumberRequest body)
    {
        InitializeHttpClient();

        string requestUri = "check-vat-number";

        HttpResponseMessage message = await _httpClient!.PostAsJsonAsync(requestUri, body);
        return await ParseContent<VatNumberResponse>(message);
    }

    /// <summary>
    /// Wrapper method for POST request /check-vat-test-service
    /// API docs: Test the check vat service
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<VatNumberResponse> CheckVatTestService(VatNumberRequest body)
    {
        InitializeHttpClient();

        string requestUri = "check-vat-test-service";
        HttpResponseMessage message = await _httpClient!.PostAsJsonAsync(requestUri, body);
        return await ParseContent<VatNumberResponse>(message);
    }

    /// <summary>
    /// Wrapper method for GET request /check-status
    /// API docs: Check the status of each member states
    /// </summary>         
    public async Task<StatusResponse> CheckStatus()
    {
        InitializeHttpClient();

        string requestUri = "check-status";

        HttpResponseMessage message = await _httpClient!.GetAsync(requestUri);
        return await ParseContent<StatusResponse>(message);
    }

    private void InitializeHttpClient()
    {
        _httpClient ??= new HttpClient()
        {
            BaseAddress = new Uri(options.BaseUrl),
        };
    }
    private static async Task<T> ParseContent<T>(HttpResponseMessage message) where T : class
    {
        if (message.IsSuccessStatusCode)
        {
            T result = await message.Content.ReadFromJsonAsync<T>() ?? throw new ViesSharpException("Serialized result was null.");
            return result;
        }
        else
        {
            ErrorResponse? errorResponseMessage = await message.Content.ReadFromJsonAsync<ErrorResponse>();
            if (errorResponseMessage is not null)
            {
                throw new ViesSharpException(errorResponseMessage);
            }

            throw new ViesSharpException();
        }
    }
}