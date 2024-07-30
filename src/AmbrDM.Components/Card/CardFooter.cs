using AmbrDM.Components.Shared;

namespace AmbrDM.Components.Card;

public class CardFooter : ContainerChildElement<ICard>
{
    protected override void Register(ICard parent)
    {
        parent.SetFooter(this);
    }

    protected override string ContainerCssClass => "card-footer text-muted";

}