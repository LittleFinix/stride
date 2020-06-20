using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Assets.Presentation.Helpers;
using Stride.Core;
using Stride.Core.Presentation.Quantum.Presenters;
using Stride.Engine;

namespace Stride.Assets.Presentation.Extensions
{
    public static class INodePresenterExtensions
    {
        public static bool CanReferenceEntityComponent(this INodePresenter node)
        {
            return ReferenceEntityComponentHelper.CanReference(node.Type) || node is MemberNodePresenter mn && ReferenceEntityComponentHelper.CanReference(mn.MemberDescriptor.MemberInfo);
        }

        public static bool CanReferenceEntity(this INodePresenter node)
        {
            return typeof(Entity) == node.Type;
        }
    }
}
