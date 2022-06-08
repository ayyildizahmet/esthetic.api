using System;

namespace Esthetic.Core.Contracts.Utilities
{
    public interface IDateTimeUtility : IUtility
    {
        DateTime Now { get; }
    }
}
