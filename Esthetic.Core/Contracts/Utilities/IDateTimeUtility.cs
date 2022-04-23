using System;

namespace MakeEat.Core.Contracts.Utilities
{
    public interface IDateTimeUtility : IUtility
    {
        DateTime Now { get; }
    }
}
