using Photon.Pun;

namespace FreezeTag;

public class GameManager : GorillaGameManager
{
    public override GameModeType GameType() => GameModeType.Infection;
    public override string GameModeName() => "FREEZE TAG";

    public override void StartPlaying()
    {

    }

    public override void OnSerializeRead(PhotonStream stream, PhotonMessageInfo info)
    {
    }

    public override void OnSerializeWrite(PhotonStream stream, PhotonMessageInfo info)
    {
    }
}