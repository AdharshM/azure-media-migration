﻿using AMSMigrate.Contracts;
using Microsoft.Extensions.Logging;

namespace AMSMigrate.Local
{
    internal class LocalFileProvider : ICloudProvider
    {
        private readonly ILoggerFactory _loggerFactory;

        public LocalFileProvider(ILoggerFactory loggerFactory) 
        {
            _loggerFactory = loggerFactory;
        }

        public ISecretUploader GetSecretProvider(KeyOptions keyOptions)
        {
            throw new NotImplementedException();
        }

        public IFileUploader GetStorageProvider(AssetOptions assetOptions)
        {
            return new LocalFileUploader(assetOptions, _loggerFactory.CreateLogger<LocalFileUploader>());
        }
    }
}
