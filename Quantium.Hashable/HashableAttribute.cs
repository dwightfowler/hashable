using System;

namespace Quantium.Hashable
{
    /// <summary>
    /// Hashing
    /// </summary>
    [AttributeUsage(/*AttributeTargets.Class |*/ AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class HashableAttribute : Attribute
    {
    }
}
