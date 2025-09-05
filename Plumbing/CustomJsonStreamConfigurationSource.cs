// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if NET10_0_OR_GREATER

namespace Microsoft.Extensions.Configuration.Json
{
    /// <summary>
    /// Represents a JSON file as an <see cref="IConfigurationSource"/>.
    /// </summary>
    public class CustomJsonStreamConfigurationSource : JsonStreamConfigurationSource
    {
        /// <summary>
        /// Builds the <see cref="CustomJsonStreamConfigurationProvider"/> for this source.
        /// </summary>
        /// <param name="builder">The <see cref="IConfigurationBuilder"/>.</param>
        /// <returns>An <see cref="CustomJsonStreamConfigurationProvider"/></returns>
        public override IConfigurationProvider Build(IConfigurationBuilder builder)
            => new CustomJsonStreamConfigurationProvider(this);
    }
}
#endif
