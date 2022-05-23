using MakeEat.Core.Contracts.Utilities;

namespace Esthetic.Core.Contracts.Utilities
{
    public interface IStringUtility : IUtility
    {
        string ToPascalCase(string input);
        string ToCamelCase(string input);
    }
}
