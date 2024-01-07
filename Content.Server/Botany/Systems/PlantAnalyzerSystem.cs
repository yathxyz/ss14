using System.Linq;
using Content.Server.Atmos.EntitySystems;
using Content.Server.Botany.Components;
using Content.Shared.DoAfter;
using Content.Shared.Interaction;
using Content.Shared.PlantAnalyzer;
using Robust.Server.GameObjects;
using Robust.Shared.Prototypes;
using Robust.Shared.Player;
using Robust.Shared.Audio.Systems;

namespace Content.Server.Botany.Systems;

public sealed class PlantAnalyzerSystem : EntitySystem
{
    [Dependency] private readonly SharedAudioSystem _audio = default!;
    [Dependency] private readonly SharedDoAfterSystem _doAfterSystem = default!;
    [Dependency] private readonly UserInterfaceSystem _uiSystem = default!;
    [Dependency] private readonly AtmosphereSystem _atmosphere = default!;
    [Dependency] private readonly IPrototypeManager _prototypeManager = default!;

    private PlantHolderComponent _plantHolder = default!;

    public override void Initialize()
    {
        base.Initialize();
    }

    private void OpenUserInterface(EntityUid user, EntityUid analyzer)
    {
        if (!TryComp<ActorComponent>(user, out var actor) || !_uiSystem.TryGetUi(analyzer, PlantAnalyzerUiKey.Key, out var ui))
            return;
        _uiSystem.OpenUi(ui, actor.PlayerSession);
    }
}
