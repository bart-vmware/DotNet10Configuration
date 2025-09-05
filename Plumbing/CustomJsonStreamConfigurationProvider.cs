// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if NET10_0_OR_GREATER

using System.IO;
using Microsoft.Extensions.Configuration.Json.Custom;

namespace Microsoft.Extensions.Configuration.Json
{
    /// <summary>
    /// Provides configuration key-value pairs that are obtained from a JSON stream.
    /// </summary>
    public class CustomJsonStreamConfigurationProvider : JsonStreamConfigurationProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomJsonStreamConfigurationProvider"/> class.
        /// </summary>
        /// <param name="source">The <see cref="CustomJsonStreamConfigurationSource"/>.</param>
        public CustomJsonStreamConfigurationProvider(CustomJsonStreamConfigurationSource source) : base(source)
        {
        }

        /// <summary>
        /// Loads JSON configuration key-value pairs from a stream into a provider.
        /// </summary>
        /// <param name="stream">The JSON <see cref="Stream"/> to load configuration data from.</param>
        public override void Load(Stream stream)
        {
            Data = CustomJsonConfigurationFileParser.Parse(stream);
        }
    }
}
#endif
