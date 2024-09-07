namespace LunarVeilChinesePack.Tiles;

public class MiscTileLocalizer : ModSystem {
    public override void Load() {
        #region AurelusSummon
        ForceLocalizeSystem.LocalizeByTypeName("AurelusSummon", "RightClick", new() {
            { "Singularity has awoken!", "填入汉化文本" },
            { "What are you doing?? Trying to summon another?", "填入汉化文本" },
            { "Come at with the key of void and moon, Verlia's Singularity awaits.", "填入汉化文本" },
        });
        #endregion
        #region AuroreanStarbomber
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.Tiles.CinderChest", "UnlockChest", new() {
            { "Heavy chest opened!", "填入汉化文本" },
        });
        #endregion
        #region FlowerSummon
        ForceLocalizeSystem.LocalizeByTypeName("FlowerSummon", "RightClick", new() {
            { "The Stone Guardian has awoken!", "填入汉化文本" },
            { "...", "..." },
        });
        #endregion
        #region Gothiv
        ForceLocalizeSystem.LocalizeByTypeName("Gothiv", "RightClick", new() {
            { "...", "..." },
        });
        #endregion
        #region JackPost
        ForceLocalizeSystem.LocalizeByTypeName("JackPost", "RightClick", new() {
            { "Jack has awoken!", "填入汉化文本" },
            { "...", "..." },
            { "Only a wandering essence can allude my precense, only for you Gothivia! :)", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName("JackPost", "MouseOver", new() {
            { "Jack's Shrine", "填入汉化文本" },
        });
        #endregion
        #region RestingGrounds
        ForceLocalizeSystem.LocalizeByTypeName("RestingGrounds", "RightClick", new() {
            { "Forgotten Puppet Daedus has Awoken!", "填入汉化文本" },
            { "...", "..." },
            { "I cannot raise my axe to one of such dedication to our goddess Gothivia, thank you for your efforts..", "填入汉化文本" },
        });
        #endregion
        #region CathedralChest
        ForceLocalizeSystem.LocalizeByTypeName("CathedralChest", "UnlockChest", new() {
            { "The chest cannot be open at day due to the Empress of the Moon, Verlia, a special seal is over it. Try again at night.", "填入汉化文本" },
        });
        #endregion
        #region VerliasShrine
        ForceLocalizeSystem.LocalizeByTypeName("VerliasShrine", "RightClick", new() {
            { "Verlia has been freed from her lantern!", "填入汉化文本" },
            { "See me in the moonlight!", "填入汉化文本" },
            { "Come at night with our kindred in hand, see you soon for our dance will commend :)", "填入汉化文本" },
        });
        #endregion
        #region MorrowChest
        ForceLocalizeSystem.LocalizeByTypeName("MorrowChest", "UnlockChest", new() {
            { "The chest cannot be open in the light of the day due to a lock, apparently these feral creatures use their weapons at night. Try again at night.", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName("MorrowChest", "RightClick", new() {
            { "The chest cannot be open in the light of the day due to a lock, apparently these feral creatures use their weapons at night. Try again at night.", "填入汉化文本" },
        });
        #endregion
        #region UnstableRift
        ForceLocalizeSystem.LocalizeByTypeName("UnstableRift", "RightClick", new() {
            { "A disturbing entity prevents the rift from opening...", "填入汉化文本" },
            { "Sylia rips through!", "填入汉化文本" },
            { "...", "..." },
        });
        #endregion
        #region SunAlter
        ForceLocalizeSystem.LocalizeByTypeName("SunAlter", "RightClick", new() {
            { "Come back with a Sun Stone to fight the warrior of the desert.", "填入汉化文本" },
            { "Sun Stalker has awoken!", "填入汉化文本" },
            { "...", "..." },
        });
        #endregion
        #region IlluriaChest
        ForceLocalizeSystem.LocalizeByTypeName("IlluriaChest", "RightClick", new() {
            { "Locked by an Overgrown plant...", "填入汉化文本" },
        });
        #endregion
        #region IshtarChest
        ForceLocalizeSystem.LocalizeByTypeName("IshtarChest", "RightClick", new() {
            { "Zui's access needed.", "填入汉化文本" },
        });
        #endregion
    }
}
