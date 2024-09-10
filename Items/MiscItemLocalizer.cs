using Stellamod.Items.Consumables;

namespace LunarVeilChinesePack.Items;

public class MiscItemLocalizer : ModSystem {
    public override void Load() {
        #region EDR
        ForceLocalizeSystem.LocalizeByType(typeof(EDR), nameof(EDR.UseItem), new() {
            { "A disruption has occured!", "出现了异常扰动！" },
            { "Initiate death protocol", "启动死亡协议..." },
            { "The end is nigh…", "末日将临..." },
            { "Tactical nuke incoming…", "战术核弹已部署..." },
            { "We’re here to contact you about your deaths extended warranty", "我们想要通知您，您的死亡保证书已延期" },
            { "Brace for impact…", "冲击警告..." },
            { "Not Contaminated life form detacted!", "侦测到未被污染的生命体！" },
            { "Prepare for voltile Termenation!", "准备迎接大范围毁灭打击！" },
            { "You’re going to have a bad time…", "你可要经历一段坏时光了..." },
            { "Usage outside of contamination detacted!", "警告：侦测到在辐射之外使用" },
        });
        #endregion
        #region LittleWand
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.Items.Accessories.AlcadChests.LittleWand", "Bad", new() {
            { "Aurorean Stars are... wait, what?", "极光之星从...等会，咋回事？" },
        });
        #endregion
        #region TomeofRaining
        ForceLocalizeSystem.LocalizeByTypeName("TomeofRaining", "UseItem", new() {
            { "Zui decided to help you make it rain!", "蕊给你弄来了几片雨云！" },
        });
        #endregion
        #region DreadMedalion
        ForceLocalizeSystem.LocalizeByTypeName("DreadMedalion", "UseItem", new() {
            { "The air fills with dread...", "恐惧的气息弥散四周..." },
        });
        #endregion
        #region RadianceStone
        ForceLocalizeSystem.LocalizeByTypeName("RadianceStone", "UseItem", new() {
            { "Zui has come to have some fun!", "我来炫翻全场！" },
            { "Lets get started!", "开始吧！" },
            { "Lets have some fun shall we?", "战斗，好玩！" },
            { "Zui is coming to party!", "我来大闹一场！" },
            { "You wanna fight today??", "想要干一场？随时奉陪！" },
            { "Here I come :)", "泰拉人，要上了！" },
            { "I don't wanna fight right now :(", "好累累，不想打架...:(" },
            { "Prepare to get rekted", "准备好大败而归吧！" },
            { "You're gonna have a good time", "这一定会是一段超棒的时光！" },
            { "Womp womp you used the item :)", "哦哦！你终于用它了！" },
        });
        #endregion
        #region STARBLOCKER
        ForceLocalizeSystem.LocalizeByTypeName("STARBLOCKER", "UseItem", new() {
            { "The Aurorean Starfall has been blocked! :(", "极光星雨被阻隔于世界之外:(" },
        });
        #endregion
    }
}
