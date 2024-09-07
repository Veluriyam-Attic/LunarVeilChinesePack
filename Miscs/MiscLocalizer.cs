using Stellamod;
using Stellamod.WorldG;

namespace LunarVeilChinesePack.Miscs;

public class MiscLocalizer : ModSystem {
    public override void Load() {
        #region 事件相关的消息 (EventWorld)
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(EventWorld).FullName, "GintzeWin", new() {
            { "The Gintze army has been defeated!", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(EventWorld).FullName, "TrySpawnGintzeArmy", new() {
            { "The Gintze army is approaching...", "填入汉化文本" },
            { "The Gintze army is returning for another round...", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(EventWorld).FullName, "TrySpawnAuroreanStarfall", new() {
            { "Aurorean Stars are falling!", "填入汉化文本" },
            { "The Aurorean starfall has ended", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(EventWorld).FullName, "PostUpdateWorld", new() {
            { "Gothivia has made a return, the skies enlighten and the sun burns bright.", "填入汉化文本" },
            { "The Aurorean starfall has ended", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(StellaMultiplayer).FullName, "HandlePacket", new() {
            { "The Aurorean Starfall has been blocked! :(", "填入汉化文本" },
        });
        #endregion
    }
}
