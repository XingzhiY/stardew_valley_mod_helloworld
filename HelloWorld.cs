using StardewModdingAPI;

namespace hello_world;

public class ModEntry : Mod
{
    public override void Entry(IModHelper helper)
    {
        Monitor.Log("Hello world",LogLevel.Debug);
    }
}
