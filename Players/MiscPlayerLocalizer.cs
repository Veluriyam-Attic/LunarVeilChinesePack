using Stellamod;

namespace LunarVeilChinesePack.Players;

public class MiscPlayerLocalizer : ModSystem {
    public override void Load() {
        #region 进入世界时的消息
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(MyPlayer).FullName, "OnEnterWorld", new() {
            { "[Lunar Veil] Hi hi! Thank you for checking out the mod! If you want more, you can check out my game Diari!", "【穹月天纱作者】你好啊！感谢你游玩我的mod！如果你还想要看看我做的其他东西，上steam搜Diari就好！##汉化交流反馈群号：909428503##" },
        });
        #endregion
        #region FlamecrestPlayer
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.Items.Accessories.Catacombs.FlamecrestPlayer", "BlockVisuals", new() {
            { "Resisted!", "抵抗！" },
            { "The Lunar tree rumbles...", "星月巨树颤抖着..." },
            { "The Abysm and Virulent stir...", "无尽深渊和瘴煞之地蠢蠢欲动..." },
            { "Azurewrath's dreams alcadize the sky.", "蔚蓝之梦将天空魔力化" },
            { "The toxic reunion begins! Gothivia's love bleeds through as the sun burns with everlasting hue.", "恒日高升，歌瑟梵的爱意从中渗出.团聚在即..." },
        });
        #endregion
        #region 进入世界时的消息
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(MyPlayer).FullName, "PostUpdate", new() {
            { "Wohooo", "芜湖！" },
            { "Omg, its something!", "哎呦！掉东西了！" },
            { "Are you disappointed? You should be.", "失望吗？失望就对啦" },
            { "Wow, you have no maidens and no luck..", "幸运女神完全不搭理你呢" },
            { "Sooo lucky!", "幸运！" },
        });
        #endregion
    }
}
