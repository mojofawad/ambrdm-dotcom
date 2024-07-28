using Microsoft.AspNetCore.Components;

namespace AmbrDM.Components;

public partial class Component1
{
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    private List<CardBody> bodies = new List<CardBody>();

    public void AddBody(CardBody body)
    {
        bodies.Add(body);
        StateHasChanged();
    }
    
    CardHeader header;

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