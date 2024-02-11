using BepInEx;
using BepInEx.Logging;
using Utilla;

namespace FreezeTag;

[BepInPlugin("crafterbot.gorillatag.freezetag", "Freeze Tag", "1.0.0"), BepInDependency("org.legoandmars.gorillatag.utilla")]
[ModdedGamemode("FREEZE TAG", "freeze tag", typeof(GameManager))]
public class Main : BaseUnityPlugin
{
    private static Main instance;

    private void Awake()
    {
        instance = this;
    }

    public static void Log(object message, LogLevel level = LogLevel.Info)
    {
        instance?.Logger.Log(level, message);
    }
}
