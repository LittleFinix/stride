using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Stride.Core;
using Stride.Core.Annotations;
using Stride.Engine;

namespace Stride.Assets.Presentation.Helpers
{
    internal static class ReferenceEntityComponentHelper
    {
        public static bool CanReference([NotNull] MemberInfo memberInfo)
        {
            if (memberInfo == null) throw new ArgumentNullException(nameof(memberInfo));

            if (memberInfo.IsDefined(typeof(ReferenceEntityComponentAttribute), true))
                return true;
            else if (memberInfo is FieldInfo field)
                return CanReference(field.FieldType);
            else if (memberInfo is PropertyInfo prop)
                return CanReference(prop.PropertyType);
            else
                return false;
        }

        public static bool CanReference([NotNull] Type type)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));

            return typeof(EntityComponent).IsAssignableFrom(type) || type.IsDefined(typeof(ReferenceEntityComponentAttribute), true);
        }

    }
}
