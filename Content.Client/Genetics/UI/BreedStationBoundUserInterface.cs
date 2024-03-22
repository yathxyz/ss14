using Content.Shared.Genetics;
using JetBrains.Annotations;

namespace Content.Client.Genetics.UI
{

    /// <summary>
    /// Initializes a <see cref="ChemMasterWindow"/> and updates it when new server messages are received.
    /// </summary>

    [UsedImplicitly]
    public sealed class BreedStationBoundUserInterface : BoundUserInterface
    {
        [ViewVariables]
        private BreedStationWindow? _window;

        public BreedStationBoundUserInterface(EntityUid owner, Enum uiKey) : base(owner, uiKey)
        {
        }

        protected override void Open()
        {
            base.Open();

            _window = new BreedStationWindow
            {
                Title = EntMan.GetComponent<MetaDataComponent>(Owner).EntityName,
            };

            _window.OpenCentered();
            _window.OnClose += Close;
            }
        }
    }
}
