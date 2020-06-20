using System;
using System.Reflection;
using Stride.Core.Annotations;

namespace Stride.Core
{
    /// <summary>
    /// Allows the target property or field to reference a component in another entity.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Interface, Inherited = true, AllowMultiple = false)]
    public sealed class ReferenceEntityComponentAttribute : Attribute
    {
        
    }
}
