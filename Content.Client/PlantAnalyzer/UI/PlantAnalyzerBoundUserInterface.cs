using Content.Shared.PlantAnalyzer;
using JetBrains.Annotations;

namespace Content.Client.PlantAnalyzer.UI;

[UsedImplicitly]
public sealed class PlantAnalyzerBoundUserInterface : BoundUserInterface
{
    [ViewVariables]
    private PlantAnalyzerWindow? _window;

    public PlantAnalyzerBoundUserInterface(EntityUid owner, Enum uiKey) : base(owner, uiKey)
    {
    }

    protected override void Open()
    {
        base.Open();
        _window = new PlantAnalyzerWindow
        {
            Title = EntMan.GetComponent<MetaDataComponent>(Owner).EntityName,
        };
        _window.OnClose += Close;
        _window.OpenToLeft();
    }

}
