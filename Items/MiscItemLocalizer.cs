using Stellamod.Items.Consumables;

namespace LunarVeilChinesePack.Items;

public class MiscItemLocalizer : ModSystem {
    public override void Load() {
        #region EDR
        // 抽象的 FullName 使用方式
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(EDR).FullName /* Stellamod.Items.Consumables.EDR */, nameof(EDR.UseItem), new() {
            { "A disruption has occured!", "填入汉化文本" },
            { "Initiate death protocol", "填入汉化文本" },
            { "The end is nigh…", "填入汉化文本" },
            { "Tactical nuke incoming…", "填入汉化文本" },
            { "We’re here to contact you about your deaths extended warranty", "填入汉化文本" },
            { "Brace for impact…", "填入汉化文本" },
            { "Not Contaminated life form detacted!", "填入汉化文本" },
            { "Prepare for voltile Termenation!", "填入汉化文本" },
            { "You’re going to have a bad time…", "填入汉化文本" },
            { "Usage outside of contamination detacted!", "填入汉化文本" },
        });
        #endregion
        #region LittleWand
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.Items.Accessories.AlcadChests.LittleWand", "Bad", new() {
            { "Aurorean Stars are... wait, what?", "填入汉化文本" },
        });
        #endregion
        #region TomeofRaining
        ForceLocalizeSystem.LocalizeByTypeName("TomeofRaining", "UseItem", new() {
            { "Zui decided to help you make it rain!", "填入汉化文本" },
        });
        #endregion
        #region DreadMedalion
        ForceLocalizeSystem.LocalizeByTypeName("DreadMedalion", "UseItem", new() {
            { "The air fills with dread...", "填入汉化文本" },
        });
        #endregion
        #region RadianceStone
        ForceLocalizeSystem.LocalizeByTypeName("RadianceStone", "UseItem", new() {
            { "Zui has come to have some fun!", "填入汉化文本" },
            { "Lets get started!", "填入汉化文本" },
            { "Lets have some fun shall we?", "填入汉化文本" },
            { "Zui is coming to party!", "填入汉化文本" },
            { "You wanna fight today??", "填入汉化文本" },
            { "Here I come :)", "填入汉化文本" },
            { "I don't wanna fight right now :(", "填入汉化文本" },
            { "Prepare to get rekted", "填入汉化文本" },
            { "You're gonna have a good time", "填入汉化文本" },
            { "Womp womp you used the item :)", "填入汉化文本" },
        });
        #endregion
        #region STARBLOCKER
        ForceLocalizeSystem.LocalizeByTypeName("STARBLOCKER", "UseItem", new() {
            { "The Aurorean Starfall has been blocked! :(", "填入汉化文本" },
        });
        #endregion
    }
}
