using Microsoft.AspNetCore.Components;

namespace AmbrDM.Components.Card;

public partial class CardBody : ComponentBase
{
    protected override void Register(ICard parent)
    {
        parent.AddBody(this);
    }
    
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    private CardTitle title;

    public void SetTitle(CardTitle title)
    {
        this.title = title;
        StateHasChanged();
    }

    private List<CardText> texts = new List<CardText>();

    public void AddText(CardText text)
    {
        texts.Add(text);
        StateHasChanged();
    }

    private List<CardLink> links = new List<CardLink>();

    public void AddLink(CardLink link)
    {
        links.Add(link);
        StateHasChanged();
    }

    public override RenderFragment RenderContent => (builder =>
    {
        int i = 0;
        builder.OpenElement(i++, "div");
        builder.AddAttribute(i++, "class", "card-body");
        if (title != null)
        {
            builder.AddContent(i++, title.RenderContent);
        }

        foreach (var text in texts)
        {
            builder.AddContent(i++, text.RenderContent);
        }

        foreach (var link in links)
        {
            builder.AddContent(i++, link.RenderContent);
        }

        builder.CloseElement();
    });
}