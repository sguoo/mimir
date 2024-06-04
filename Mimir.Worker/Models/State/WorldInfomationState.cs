using Bencodex;
using Bencodex.Types;
using Libplanet.Crypto;
using Nekoyume.Model;
using Nekoyume.Model.State;

namespace Mimir.Worker.Models;

public class WorldInformationState : State
{
    public IDictionary<int, WorldInformation.World> WorldInformation;

    public WorldInformationState(Address address, WorldInformation worldInformation)
        : base(address)
    {
        WorldInformation = ((Dictionary)worldInformation.Serialize()).ToDictionary(
            (KeyValuePair<IKey, IValue> kv) => kv.Key.ToInteger(),
            (KeyValuePair<IKey, IValue> kv) => new WorldInformation.World((Dictionary)kv.Value)
        );
    }
}
