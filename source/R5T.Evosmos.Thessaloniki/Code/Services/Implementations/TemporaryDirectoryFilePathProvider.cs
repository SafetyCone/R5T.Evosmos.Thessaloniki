using System;

using R5T.Lombardy;
using R5T.Thessaloniki;using R5T.T0064;


namespace R5T.Evosmos.Thessaloniki
{[ServiceImplementationMarker]
    public class TemporaryDirectoryFilePathProvider : ITemporaryDirectoryFilePathProvider,IServiceImplementation
    {
        private ITemporaryDirectoryPathProvider TemporaryDirectoryPathProvider { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public TemporaryDirectoryFilePathProvider(
            ITemporaryDirectoryPathProvider temporaryDirectoryPathProvider,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.TemporaryDirectoryPathProvider = temporaryDirectoryPathProvider;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public string GetTemporaryDirectoryFilePath(string fileName)
        {
            var temporaryDirectoryPath = this.TemporaryDirectoryPathProvider.GetTemporaryDirectoryPath();

            var filePath = this.StringlyTypedPathOperator.GetFilePath(temporaryDirectoryPath, fileName);
            return filePath;
        }
    }
}
