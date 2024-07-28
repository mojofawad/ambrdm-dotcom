using AmbrDM.Components.Shared;

namespace AmbrDM.Components.Card;

public class CardTitle : FlexibleContainerChildElement<ICardBody>
{
    protected override void Register(ICardBody parent)
    {
        parent.SetTitle(this);
    }

    protected override string ContainerCssClass => "card-title";

    public override ElementType ElementType { get; set; } = ElementType.H5;
}
