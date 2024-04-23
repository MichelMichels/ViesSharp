using System.Text.Json.Serialization;

namespace MichelMichels.ViesSharp.Models;

public class VatNumberRequest
{
    [JsonPropertyName("countryCode")]
    public string CountryCode { get; set; } = string.Empty;

    [JsonPropertyName("vatNumber")]
    public string VatNumber { get; set; } = string.Empty;

    [JsonPropertyName("requesterMemberStateCode")]
    public string RequesterMemberStateCode { get; set; } = string.Empty;

    [JsonPropertyName("requesterNumber")]
    public string RequesterNumber { get; set; } = string.Empty;

    [JsonPropertyName("traderName")]
    public string TraderName { get; set; } = string.Empty;

    [JsonPropertyName("traderStreet")]
    public string TraderStreet { get; set; } = string.Empty;

    [JsonPropertyName("traderPostalCode")]
    public string TraderPostalCode { get; set; } = string.Empty;

    [JsonPropertyName("traderCity")]
    public string TraderCity { get; set; } = string.Empty;

    [JsonPropertyName("traderCompanyType")]
    public string TraderCompanyType { get; set; } = string.Empty;
}
