using System.Linq;
using System.Reflection;
// Copyright (c) Stride contributors (https://stride3d.net) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
using Stride.Engine;
using Stride.Core.Presentation.Quantum;
using Stride.Core.Presentation.Quantum.View;
using Stride.Core.Presentation.Quantum.ViewModels;
using System.Diagnostics;
using Stride.Assets.Presentation.Helpers;
using Stride.Assets.Presentation.Extensions;

namespace Stride.Assets.Presentation.TemplateProviders
{
    public class EntityComponentReferenceTemplateProvider : NodeViewModelTemplateProvider
    {
        public override string Name => "EntityComponentReference";

        public override bool MatchNode(NodeViewModel node)
        {
            return (ReferenceEntityComponentHelper.CanReference(node.Type) || node.NodePresenters.Any(p => p.CanReferenceEntityComponent()))
                && node.Parent?.Type != typeof(EntityComponentCollection);
        }
    }
}
