using Robust.Shared.Serialization;

namespace Content.Shared.Genetics;

public sealed class SharedBreedStation
{
    /// <summary>
    /// Hold constants that are shared between client and server.
    /// </summary>

    [Serializable, NetSerializable]
    public enum BreedStationUiKey
    {
        Key
    }
}
