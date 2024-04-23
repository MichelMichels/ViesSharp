using MichelMichels.ViesSharp.Models;

namespace MichelMichels.ViesSharp.Exceptions;

public class ViesSharpException : Exception
{
    public ViesSharpException()
    {
    }

    public ViesSharpException(ErrorResponse errorResponse)
    {
        ErrorResponse = errorResponse;
    }

    public ViesSharpException(string? message) : base(message)
    {
    }

    public ViesSharpException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    public ErrorResponse? ErrorResponse { get; }
}
