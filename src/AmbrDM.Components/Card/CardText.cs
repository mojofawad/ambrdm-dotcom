using AmbrDM.Components.Shared;

namespace AmbrDM.Components.Card;

public class CardText : ContainerChildElement<ICardBody>
{
    protected override void Register(ICardBody parent)
    {
        parent.AddText(this);
    }

    protected override string ContainerCssClass => "card-text";
    protected override ElementType ContainerElementType => ElementType.P;
}