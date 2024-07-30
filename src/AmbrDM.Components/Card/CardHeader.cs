using System.ComponentModel;
using AmbrDM.Components.Shared;

namespace AmbrDM.Components.Card;

public class CardHeader : FlexibleContainerChildElement<ICard>
{
    protected override void Register(ICard parent)
    {
        parent.SetHeader(this);
    }

    protected override string ContainerCssClass => "card-header";

}