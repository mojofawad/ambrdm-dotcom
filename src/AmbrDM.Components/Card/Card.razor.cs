using Microsoft.AspNetCore.Components;

namespace AmbrDM.Components.Card;

public partial class Card : ComponentBase
{
    [Parameter] public RenderFragment ChildContent { get; set; }

    private List<CardBody> bodies = new List<CardBody>();

    public void AddBody(CardBody body)
    {
        bodies.Add(body);
        StateHasChanged();
    }

    private CardHeader header;

    public void SetHeader(CardHeader header)
    {
        this.header = header;
        StateHasChanged();
    }

    private CardFooter footer;

    public void SetFooter(CardFooter footer)
    {
        this.footer = footer;
        StateHasChanged();
    }

    public void ChildStateChanged()
    {
        StateHasChanged();
    }
}