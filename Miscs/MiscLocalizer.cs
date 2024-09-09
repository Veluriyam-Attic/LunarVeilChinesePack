using Stellamod;
using Stellamod.WorldG;

namespace LunarVeilChinesePack.Miscs;

public class MiscLocalizer : ModSystem {
    public override void Load() {
        #region 事件相关的消息 (EventWorld)
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(EventWorld).FullName, "GintzeWin", new() {
            { "The Gintze army has been defeated!", "玄铁军团已被击败！" },
        });
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(EventWorld).FullName, "TrySpawnGintzeArmy", new() {
            { "The Gintze army is approaching...", "玄铁军团正在逼近..." },
            { "The Gintze army is returning for another round...", "玄铁军团准备再战一场..." },
        });
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(EventWorld).FullName, "TrySpawnAuroreanStarfall", new() {
            { "Aurorean Stars are falling!", "极光之星从天而降！" },
            { "The Aurorean starfall has ended", "极光星雨结束了" },
        });
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(EventWorld).FullName, "PostUpdateWorld", new() {
            { "Gothivia has made a return, the skies enlighten and the sun burns bright.", "琉阳当空，霞彩遮天，歌瑟梵已然归来." },
            { "The Aurorean starfall has ended", "极光星雨结束了" },
        });
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(StellaMultiplayer).FullName, "HandlePacket", new() {
            { "The Aurorean Starfall has been blocked! :(", "极光星雨被阻隔于世界之外:(" },
        });
        #endregion
    }
}
