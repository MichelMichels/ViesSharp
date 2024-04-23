using System.Text.Json.Serialization;

namespace MichelMichels.ViesSharp.Models;

public class Country
{
    [JsonPropertyName("countryCode")]
    public string CountryCode { get; set; } = string.Empty;

    [JsonPropertyName("availability")]
    public string Availability { get; set; } = string.Empty;
}
