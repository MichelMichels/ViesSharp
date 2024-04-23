using MichelMichels.ViesSharp.Models;

namespace MichelMichels.ViesSharp;

public interface IViesSharpClient
{
    Task<VatNumberResponse> CheckVatNumber(VatNumberRequest body);
    Task<VatNumberResponse> CheckVatTestService(VatNumberRequest body);
    Task<StatusResponse> CheckStatus();
}