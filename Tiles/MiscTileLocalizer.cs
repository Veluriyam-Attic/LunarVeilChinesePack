using Stellamod.Tiles;
using Stellamod.Tiles.Abyss.Aurelus;
using Stellamod.Tiles.Catacombs;
using Stellamod.Tiles.Ishtar;
using Stellamod.Tiles.ShrineBreakers.Govheil;
using Stellamod.Tiles.ShrineBreakers.Underground;
using Stellamod.Tiles.Structures.AlcadizNGovheil;
using Stellamod.Tiles.Structures.UnderworldRuins;

namespace LunarVeilChinesePack.Tiles;

public class MiscTileLocalizer : ModSystem
{
    public override void Load()
    {
        #region AurelusSummon
        ForceLocalizeSystem.LocalizeByTypeName("AurelusSummon", "RightClick", new() {
            { "Singularity has awoken!", "奇点已苏醒！" },
            { "What are you doing?? Trying to summon another?", "你要干什么？还要再召唤一个吗？" },
            { "Come at with the key of void and moon, Verlia's Singularity awaits.", "唯有持有虚无与皎月之钥者，方可与薇莉娅共舞" },
        });
        #endregion
        #region CinderChest
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.Tiles.CinderChest", "UnlockChest", new() {
            { "Heavy chest opened!", "开启了重型宝箱！" },
        });
        #endregion
        #region FlowerSummon
        ForceLocalizeSystem.LocalizeByType(typeof(FlowerSummon), nameof(FlowerSummon.MouseOver), new() {
            { "Old Guard's Shrine", "石心之花" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(FlowerSummon), nameof(FlowerSummon.RightClick), new() {
            { "The Stone Guardian has awoken!", "石心圣卫已苏醒！" },
            { "...", "..." },
        });
        #endregion
        #region Gothiv
        ForceLocalizeSystem.LocalizeByType(typeof(Gothiv), nameof(Gothiv.RightClick), new() {
            { "...", "..." },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(Gothiv), nameof(Gothiv.MouseOver), new() {
            { "Gothivia's sleeping hut", "歌瑟梵的小棚屋" },
        });
        #endregion
        #region JackPost
        ForceLocalizeSystem.LocalizeByType(typeof(JackPost), nameof(JackPost.RightClick), new() {
            { "Jack has awoken!", "灯笼杰克已苏醒！" },
            { "...", "..." },
            { "Only a wandering essence can allude my precense, only for you Gothivia! :)", "带上漂浪焰华来，全部献给歌瑟梵——" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(JackPost), nameof(JackPost.MouseOver), new() {
            { "Jack's Shrine", "灯笼杰克" },
        });
        #endregion
        #region RestingGrounds
        ForceLocalizeSystem.LocalizeByType(typeof(RestingGrounds), nameof(RestingGrounds.RightClick), new() {
            { "Forgotten Puppet Daedus has Awoken!", "遗世石偶，代达斯已苏醒!" },
            { "...", "..." },
            { "I cannot raise my axe to one of such dedication to our goddess Gothivia, thank you for your efforts..", "面对为歌瑟梵如此付出之人，我无从下手...感谢您的努力." },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(RestingGrounds), nameof(RestingGrounds.MouseOver), new() {
            { "Disturb Ruined Tablet?", "扰动遗迹石碑？" },
        });
        #endregion
        #region CathedralChest
        ForceLocalizeSystem.LocalizeByTypeName("CathedralChest", "UnlockChest", new() {
            { "The chest cannot be open at day due to the Empress of the Moon, Verlia, a special seal is over it. Try again at night.", "薇莉娅的魔力在白天将箱子牢牢锁住.等夜晚再来试试." },
        });
        #endregion
        #region VerliasShrine
        ForceLocalizeSystem.LocalizeByTypeName("VerliasShrine", "RightClick", new() {
            { "Verlia has been freed from her lantern!", "薇莉娅之魂挣脱了提灯的束缚！" },
            { "See me in the moonlight!", "月下最宜见面！" },
            { "Come at night with our kindred in hand, see you soon for our dance will commend :)", "三更来见灯在手，舞醉月下不知愁" },
        });
        ForceLocalizeSystem.LocalizeByTypeName("VerliasShrine", "MouseOver", new() {
            { "Verlia's Shrine", "薇莉娅圣坛" },
        });
        #endregion
        #region MorrowChest
        ForceLocalizeSystem.LocalizeByTypeName("MorrowChest", "UnlockChest", new() {
            { "The chest cannot be open in the light of the day due to a lock, apparently these feral creatures use their weapons at night. Try again at night.", "箱子被上锁了.看来那些野生的家伙们只有晚上才会使用里面的东西.晚上再来试试." },
        });
        ForceLocalizeSystem.LocalizeByTypeName("MorrowChest", "RightClick", new() {
            { "The chest cannot be open in the light of the day due to a lock, apparently these feral creatures use their weapons at night. Try again at night.", "箱子被上锁了.看来那些野生的家伙们只有晚上才会使用里面的东西.晚上再来试试." },
        });
        #endregion
        #region UnstableRift
        ForceLocalizeSystem.LocalizeByType(typeof(UnstableRift), nameof(UnstableRift.RightClick), new() {
            { "A disturbing entity prevents the rift from opening...", "一个可怖的存在抑制着裂隙..." },
            { "Sylia rips through!", "赛莉亚破影而出！" },
            { "...", "..." },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(UnstableRift), nameof(UnstableRift.MouseOver), new() {
            { "Disturb the Unstable Rift...?", "试探不稳定裂隙...？" },
        });
        #endregion
        #region SunAlter
        ForceLocalizeSystem.LocalizeByTypeName("SunAlter", "RightClick", new() {
            { "Come back with a Sun Stone to fight the warrior of the desert.", "带上耀日宝石来挑战沙漠中的战士." },
            { "Sun Stalker has awoken!", "猎日游隼已苏醒！" },
            { "...", "..." },
        });
        #endregion
        #region IlluriaChest
        ForceLocalizeSystem.LocalizeByTypeName("IlluriaChest", "RightClick", new() {
            { "Locked by an Overgrown plant...", "一种奇特的植物长满其上，将它牢牢封死." },
        });
        #endregion
        #region IshtarChest
        ForceLocalizeSystem.LocalizeByTypeName("IshtarChest", "RightClick", new() {
            { "Zui's access needed.", "让蕊帮你打开这个！" },
        });
        #endregion

        #region AurelusDoorClosed
        ForceLocalizeSystem.LocalizeByType(typeof(AurelusDoorClosed), "get_FailString", new() {
            { "You're not ready yet! Key needed!", "你还需要一把钥匙！" },
        });
        #endregion
        #region CatacombsDoorClosed
        ForceLocalizeSystem.LocalizeByType(typeof(CatacombsDoorClosed), "get_FailString", new() {
            { "Kill wall of flesh! Key needed!", "先击杀血肉之墙并拿到钥匙！" },
        });
        #endregion
        #region IshtarDoorClosed
        ForceLocalizeSystem.LocalizeByType(typeof(IshtarDoorClosed), "get_FailString", new() {
            { "The door requires an Ishtar Key.", "需要狂渊钥匙" },
        });
        #endregion
        #region GothivDoorClosed
        ForceLocalizeSystem.LocalizeByType(typeof(GothivDoorClosed), "get_FailString", new() {
            { "Hun, you cant open this door yet :(", "嗯...你还开不了这扇门" },
        });
        #endregion

        #region 一些 MouseOver
        Dictionary<string, string> breakMeLocalization = new(){
            { "Break Me!", "打破我！" },
        };
        ForceLocalizeSystem.LocalizeByType(typeof(ShrineAlcaPowderC), nameof(ShrineAlcaPowderC.MouseOver), breakMeLocalization);
        ForceLocalizeSystem.LocalizeByType(typeof(ShrineBUAN), nameof(ShrineBUAN.MouseOver), breakMeLocalization);
        ForceLocalizeSystem.LocalizeByType(typeof(ShrineGardenWreckerC), nameof(ShrineGardenWreckerC.MouseOver), breakMeLocalization);
        ForceLocalizeSystem.LocalizeByType(typeof(ShrineHalhurishC), nameof(ShrineHalhurishC.MouseOver), breakMeLocalization);
        ForceLocalizeSystem.LocalizeByType(typeof(ShrineLifeC), nameof(ShrineSolMothC.MouseOver), breakMeLocalization);
        ForceLocalizeSystem.LocalizeByType(typeof(ShrineLights), nameof(ShrineLights.MouseOver), breakMeLocalization);
        ForceLocalizeSystem.LocalizeByType(typeof(ShrineSolMothC), nameof(ShrineSolMothC.MouseOver), breakMeLocalization);

        ForceLocalizeSystem.LocalizeByType(typeof(ShrineBridgetC), nameof(ShrineBridgetC.MouseOver), new() {
            { "Hey hey over here break me please :(", "嘿！嘿！那边的！过来救我出去！" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(LabCrystal), nameof(LabCrystal.MouseOver), new() {
            { "Insert a Focal Crystal", "插入聚焦水晶" },
        });
        #endregion
    }
}
