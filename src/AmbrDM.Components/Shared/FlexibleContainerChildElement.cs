using Microsoft.AspNetCore.Components;

namespace AmbrDM.Components.Shared;

public abstract class FlexibleContainerChildElement<TParent> : ContainerChildElement<TParent>
{
    [Parameter] public ElementType ElementType { get; set; } = ElementType.Div;

    protected override ElementType ContainerElementType => ElementType;

}