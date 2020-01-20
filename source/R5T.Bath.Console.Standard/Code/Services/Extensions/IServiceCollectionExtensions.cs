using System;

using Microsoft.Extensions.DependencyInjection;


namespace R5T.Bath.Console.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddConsoleHumanOutput(this IServiceCollection services)
        {
            services.AddSingleton<IHumanOutput, ConsoleHumanOutput>();

            return services;
        }
    }
}
