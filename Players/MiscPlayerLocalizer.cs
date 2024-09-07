using Stellamod;

namespace LunarVeilChinesePack.Players;

public class MiscPlayerLocalizer : ModSystem {
    public override void Load() {
        #region 进入世界时的消息
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(MyPlayer).FullName, "OnEnterWorld", new() {
            { "[Lunar Veil] Hi hi! Thank you for checking out the mod! If you want more, you can check out my game Diari!", "填入汉化文本" },
        });
        #endregion
        #region FlamecrestPlayer
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.Items.Accessories.Catacombs.FlamecrestPlayer", "BlockVisuals", new() {
            { "Resisted!", "填入汉化文本" },
            { "The Lunar tree rumbles...", "填入汉化文本" },
            { "The Abysm and Virulent stir...", "填入汉化文本" },
            { "Azurewrath's dreams alcadize the sky.", "填入汉化文本" },
            { "The toxic reunion begins! Gothivia's love bleeds through as the sun burns with everlasting hue.", "填入汉化文本" },
        });
        #endregion
        #region 进入世界时的消息
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(MyPlayer).FullName, "PostUpdate", new() {
            { "Wohooo", "填入汉化文本" },
            { "Omg, its something!", "填入汉化文本" },
            { "Are you disappointed? You should be.", "填入汉化文本" },
            { "Wow, you have no maidens and no luck..", "填入汉化文本" },
            { "Sooo lucky!", "填入汉化文本" },
        });
        #endregion
    }
}
