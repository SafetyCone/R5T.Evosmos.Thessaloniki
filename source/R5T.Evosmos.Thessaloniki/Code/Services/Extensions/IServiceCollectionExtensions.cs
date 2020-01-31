using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Lombardy;


namespace R5T.Evosmos.Thessaloniki
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="TemporaryDirectoryFilePathProvider"/> implementation of <see cref="ITemporaryDirectoryFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddThessalonikiTemporaryDirectoryFilePathProvider(this IServiceCollection services,
            ServiceAction<ITemporaryDirectoryFilePathProvider> addTemporaryDirectoryFilePathProvider,
            ServiceAction<IStringlyTypedPathOperator> addStringlyTypedPathOperator)
        {
            services
                .AddSingleton<ITemporaryDirectoryFilePathProvider, TemporaryDirectoryFilePathProvider>()
                .RunServiceAction(addTemporaryDirectoryFilePathProvider)
                .RunServiceAction(addStringlyTypedPathOperator)
                ;

            return services;
        }
    }
}
