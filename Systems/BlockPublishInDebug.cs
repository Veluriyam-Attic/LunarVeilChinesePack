using LunarVeilChinesePackPublicizerPart;
using MonoMod.RuntimeDetour;

namespace LunarVeilChinesePack.Systems;

#if DEBUG
public class BlockPublishInDebug : ModSystem
{
    Hook? blockHook;
    public override void Load()
    {
        blockHook = BlockPublishHelper.BlockPublish(m => m == nameof(LunarVeilChinesePack), "禁止在 DEBUG 模式下发布此模组!");
    }
}
#endif
