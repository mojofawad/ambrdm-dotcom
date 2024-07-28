using AmbrDM.Components.Shared;
using Microsoft.AspNetCore.Components;

namespace AmbrDM.Components.Card;

public class CardLink : ChildElement<ICardBody>
{
    protected override void Register(ICardBody parent)
    {
        parent.AddLink(this);
    }
    
    [Parameter] public RenderFragment ChildContent { get; set; }
    
    [Parameter] public string Target { get; set; }

    public override RenderFragment RenderContent => (builder =>
    {
        builder.OpenElement(0, "a");
        builder.AddAttribute(1, "class", "card-link");
        builder.AddAttribute(2, "href", Target);
        builder.AddContent(3, ChildContent);
        builder.CloseElement();
    });
}