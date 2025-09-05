namespace Microsoft.Extensions.Configuration;

internal static class SR
{
    public const string Error_UnsupportedJSONToken = "Error_UnsupportedJSONToken";
    public const string Error_KeyIsDuplicated = "Error_KeyIsDuplicated";
    public const string Error_InvalidTopLevelJSONElement = "Error_InvalidTopLevelJSONElement";
    public const string Error_ParameterHasNoMatchingConfig = "Error_ParameterHasNoMatchingConfig";
    public const string Error_ParameterBeingBoundToIsUnnamed = "Error_ParameterBeingBoundToIsUnnamed";
    public const string Error_UnsupportedMultidimensionalArray = "Error_UnsupportedMultidimensionalArray";
    public const string Error_GeneralErrorWhenBinding = "Error_GeneralErrorWhenBinding";
    public const string Error_FailedToActivate = "Error_FailedToActivate";
    public const string Error_ConstructorParametersDoNotMatchProperties = "Error_ConstructorParametersDoNotMatchProperties";
    public const string Error_CannotBindToConstructorParameter = "Error_CannotBindToConstructorParameter";
    public const string Error_MultipleParameterizedConstructors = "Error_MultipleParameterizedConstructors";
    public const string Error_MissingPublicInstanceConstructor = "Error_MissingPublicInstanceConstructor";
    public const string Error_CannotActivateAbstractOrInterface = "Error_CannotActivateAbstractOrInterface";
    public const string Error_FailedBinding = "Error_FailedBinding";
    public const string Error_MissingConfig = "Error_MissingConfig";

    public static string Format(string message, params object?[] parameters)
    {
        return message;
    }
}
