using MichelMichels.ViesSharp.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/check-vat-number", () => new ErrorResponse()
{
    IsActionSucceeded = false,
    ErrorWrappers =
    [
        new ErrorWrapper()
        {
            Error = "MS_MAX_CONCURRENT_RQ",
        }
    ]
});

app.Run();
