using AutoTableDotnet.Interfaces;
using AutoTableDotnet.Services;

namespace AutoTableDotnet.Extensions;

public static class ServicesExtension
{
    public static void ConfigureServices(this IServiceCollection services)
    {
        services.AddScoped<ITokenEmitterService, TokenEmitterService>();
    }
}