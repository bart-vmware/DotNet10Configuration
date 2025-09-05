using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Options;

namespace DotNet10Configuration;

public static class CustomExtensions
{
    public static IConfigurationBuilder AddCustomJsonStream(this IConfigurationBuilder builder, Stream stream)
    {
        ArgumentNullException.ThrowIfNull(builder);

#if NET10_0_OR_GREATER
        return builder.Add<CustomJsonStreamConfigurationSource>(s => s.Stream = stream);
#else
        return builder.Add<JsonStreamConfigurationSource>(s => s.Stream = stream);
#endif
    }

    public static OptionsBuilder<TOptions> CustomBindConfiguration<TOptions>(
        this OptionsBuilder<TOptions> optionsBuilder,
        string configSectionPath,
        Action<BinderOptions>? configureBinder = null)
        where TOptions : class
    {
        ArgumentNullException.ThrowIfNull(optionsBuilder);
        ArgumentNullException.ThrowIfNull(configSectionPath);

        optionsBuilder.Configure<IConfiguration>((opts, config) =>
        {
            IConfiguration section = string.Equals("", configSectionPath, StringComparison.OrdinalIgnoreCase)
                ? config
                : config.GetSection(configSectionPath);
#if NET10_0_OR_GREATER
            Microsoft.Extensions.Configuration.Custom.CustomConfigurationBinder.Bind(section, opts, configureBinder);
#else
            ConfigurationBinder.Bind(section, opts, configureBinder);
#endif
        });

        optionsBuilder.Services.AddSingleton<IOptionsChangeTokenSource<TOptions>, ConfigurationChangeTokenSource<TOptions>>(sp =>
        {
            return new ConfigurationChangeTokenSource<TOptions>(optionsBuilder.Name, sp.GetRequiredService<IConfiguration>());
        });

        return optionsBuilder;
    }
}