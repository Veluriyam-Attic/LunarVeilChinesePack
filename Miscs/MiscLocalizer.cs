using Microsoft.Xna.Framework;
using Stellamod;
using Stellamod.DropRules;
using Stellamod.Effects;
using Stellamod.Effects.Primitives;
using Stellamod.Helpers;
using Stellamod.Trails;
using Stellamod.UI.Scripture;
using Stellamod.WorldG;
using System.Reflection;
using Terraria.ModLoader.Core;

namespace LunarVeilChinesePack.Miscs;

public class MiscLocalizer : ModSystem {
    public override void Load() {
        #region 事件相关的消息 (EventWorld)
        ForceLocalizeSystem.LocalizeByType(typeof(EventWorld), "GintzeWin", new() {
            { "The Gintze army has been defeated!", "玄铁军团已被击败！" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(EventWorld), "TrySpawnGintzeArmy", new() {
            { "The Gintze army is approaching...", "玄铁军团正在逼近..." },
            { "The Gintze army is returning for another round...", "玄铁军团准备再战一场..." },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(EventWorld), "TrySpawnAuroreanStarfall", new() {
            { "Aurorean Stars are falling!", "极光之星从天而降！" },
            { "The Aurorean starfall has ended", "极光星雨结束了" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(EventWorld), "PostUpdateWorld", new() {
            { "Gothivia has made a return, the skies enlighten and the sun burns bright.", "琉阳当空，霞彩遮天，歌瑟梵已然归来." },
            { "The Aurorean starfall has ended", "极光星雨结束了" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(StellaMultiplayer), "HandlePacket", new() {
            { "The Aurorean Starfall has been blocked! :(", "极光星雨被阻隔于世界之外:(" },
        });
        #endregion
        #region 条件
        // 主要用于商店注册, 如果同时启用 Shop Expand 能在查询商店时看到汉化效果
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.CustomConditions", ".cctor", new() {
            { "Defeated Fenix", "击败凤涅克丝" },
            { "Killed Singularity Fragment", "击败破碎奇点" },
            { "Defeated Daedus", "击败代达斯" },
            { "Sewing Kit must be Equipped", "必须装备着织影套件包" },
        });
        #endregion
        #region 掉落条件
        ForceLocalizeSystem.LocalizeByType(typeof(BloodmoonDropRule), nameof(BloodmoonDropRule.GetConditionDescription), new() {
            { "During a Bloodmoon", "在血月时" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(HardmodeDropRule), nameof(HardmodeDropRule.GetConditionDescription), new() {
            { "During Hardmode", "在困难模式中" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(PlanteraDropRule), nameof(PlanteraDropRule.GetConditionDescription), new() {
            { "After skeletron is defeated", "在骷髅王被击败后" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(SkeletronDropRule), nameof(SkeletronDropRule.GetConditionDescription), new() {
            { "After skeletron is defeated", "在骷髅王被击败后" },
        });
        #endregion
        #region 报错信息
        // 配置是否汉化报错信息?
        if (AlwaysFalse()) {
            // 可以无需汉化
            ForceLocalizeSystem.LocalizeInOrderByType(typeof(Primitive3DStrip), ".ctor", new() {
                { "In order to create a primitive 3D strip, a non-null ", "In order to create a primitive 3D strip, a non-null " },
                { "height", "height" },
                { "color", "color" },
                { " function must be specified.", " function must be specified." },
            });
            ForceLocalizeSystem.LocalizeInOrderByType(typeof(PrimitiveTrailCopy), ".ctor", new() {
                { "In order to create a primitive trail, a non-null ", "In order to create a primitive trail, a non-null " },
                { "height", "height" },
                { "color", "color" },
                { " function must be specified.", " function must be specified." },
            });
            ForceLocalizeSystem.LocalizeInOrderByType(typeof(PrimitiveTrail), ".ctor", new() {
                { "In order to create a primitive trail, a non-null ", "In order to create a primitive trail, a non-null " },
                { "height", "height" },
                { "color", "color" },
                { " function must be specified.", " function must be specified." },
            });
            ForceLocalizeSystem.Localize(typeof(EaseBuilder).GetMethod(nameof(EaseBuilder.AddPoint), [typeof(Vector2), typeof(EaseFunction)]), new() {
                { "X value of point is not in valid range!", "X value of point is not in valid range!" },
                { "New point has an x value less than the previous point when it should be greater or equal", "New point has an x value less than the previous point when it should be greater or equal" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StructureLoader), "ReadModWall", new() {
                { "Mod was not loaded for walltype, returning 0", "Mod was not loaded for walltype, returning 0" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StructureLoader), "ReadModTile", new() {
                { "Mod was not loaded, placing dirt instead", "Mod was not loaded, placing dirt instead" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StructureLoader), "WriteModdedWall", new() {
                { "Write modded wall was called with a vanilla wall type", "Write modded wall was called with a vanilla wall type" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StructureLoader), "WriteVanillaWall", new() {
                { "Write vanilla wall was called with a modded wall type, type = ", "Write vanilla wall was called with a modded wall type, type = " },
                { " and wallid count = ", " and wallid count = " },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StructureLoader), "WriteVanillaTile", new() {
                { "modded tile was used in WriteVanillaTile", "modded tile was used in WriteVanillaTile" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StructureLoader), "WriteModdedTile", new() {
                { "Write modded tile was called with a vanilla tile type", "Write modded tile was called with a vanilla tile type" },
            });
        }
        #endregion
        #region UI
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.UI.Dialogue.DialoguePanel", "OnInitialize", new() {
            { "Hi There :D", "你好啊 :D" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(ScripturePanel), "OnInitialize", new() {
            { "Hello world!", "Hello world!" },
        });
        #endregion
        #region 世界生成
        Dictionary<string, string> worldGenLocalizations = new(){
            { "The Veiled people planting trees!", "正在观察天纱臣民种树" },
            { "Golden Ambience ruining the world", "正在准备BGM" },
            { "Buring the landscape with Cinder and Fable", "正在用古谕之火灼烧大地" },
            { "Ereshkigal secretly hiding Sigfried", "厄莉什基迦勒正在藏起齐格飞" },
            { "Creating life near spawn :)", "正在为出生点附近带去生机" },
            { "Witches spreading love all inside you!", "正在感受女巫们的爱意" },
            { "You aren't escaping the Kill Pillars", "你可逃不脱打四柱的命运" },
            { "Adding life to the world!", "正在为世界增加更多生灵" },
            { "Building Gintze houses", "正在为玄铁军团盖房子" },
            { "Bird building alters", "正在看鸟筑巢" },
            { "Gia living fruitfully", "正在观察吉娅做实验" },
            { "Definitely not making elder guardians from minecraft.", "绝对不是正在将我的世界中的远古守卫者偷过来" },
            { "Definitely not making even more trapped elder guardians", "绝对不是正在将我的世界中的更多远古守卫者偷过来" },
            { "Definitely not making some trapped elder guardians", "绝对不是正在将我的世界中的远古守卫者和陷阱偷过来" },
            { "The Almighty weapon being burried", "正在埋藏远古神兵" },
            { "Burning the world with catacombs", "正在建造烈火墓穴" },
            { "Trapping the world with catacombs", "正在建造陷阱墓穴" },
            { "Rallad killing people", "正在往死里嗨" },
            { "Finding a place for the shop", "正在找地方建造商店" },
            { "Singularities singing!", "正在听奇点歌唱" },
            { "Irradia marrying Paraffin instead of Delgrim", "正在劝说伊瑞蒂安和帕拉芬结婚，而不是戴尔格林" },
            { "Shifting Shadows deep in the Ice", "正在冰雪的深处挪动阴影" },
            { "Virulifying the Morrow", "正在散播瘴煞" },
            { "Residents of the veil believing in a god", "正在观察天纱臣民祭拜神明" },
            { "Residents of the veil crafting chasms", "正在观察天纱臣民制作物品" },
            { "Fighting the Virulent with magic", "正在用魔法对抗瘴煞" },
            { "Niivi protecting the cities above.", "正在观察尼伊维保卫城市" },
            { "Leaving the Royal Capital", "正在撤出皇都" },
            { "Scorching Gild and Arnchar burning into the world", "正在加入赤铁和炽金" },
            { "Scorching Arnchar into the world", "正在加入赤铁" },
            { "Scorching more Arnchar into the world", "正在加入更多赤铁" },
            { "Freezing the world with Frile", "正在冻结月冰" },
            { "Blackening Stones for racist effect", "正在把墙壁涂黑" },
            { "Veribloom forgetting their memories", "正在让薇绿失忆" },
            { "Getting shafted", "正在被诈骗" },
            { "Sylia using magic in the Underworld", "正在观察赛利亚在地狱作法" },
            { "Hunters getting kicked out", "正在驱逐猎人" },
            { "Hunters settling down", "正在引导猎人定居" },
            { "Praising our lord and savior Niivi", "正在歌颂我们伟大的尼伊维" },
            { "Verlia Ark", "正在发电" },
            { "Veldris Building his house", "正在观察维尔德斯造房子" },
            { "Sigfried being demoralized", "正在让齐格飞破防" },
            { "Azurerin Sleeping the whole time", "正在偷窥艾祖瑞霖睡觉" },
            { "Cozmire getting her singularity stolen", "正在偷取天寰神巫的奇点" },
            { "Lumi collecting singularities", "正在观察琉明收集奇点" },
            { "Gothivia preparing her escape.", "正在祝歌瑟梵逃脱顺利" },
            { "Dreading..", "正在害怕" },
            { "Gild settling in the ground", "正在稳定地层中的金光" },
        };
        if (AlwaysFalse()) {
            // 这一块不用汉化
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenFabledTrees", new() {
                { "The Veiled people planting trees!", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenAmbience", new() {
                { "Golden Ambience ruining the world", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenFabiliaRuin", new() {
                { "Buring the landscape with Cinder and Fable", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenManor", new() {
                { "Ereshkigal secretly hiding Sigfried", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenStoneCastle", new() {
                { "Creating life near spawn :)", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenXixVillage", new() {
                { "Witches spreading love all inside you!", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenGraving", new() {
                { "You aren't escaping the Kill Pillars", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenWindmills", new() {
                { "Adding life to the world!", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenMed", new() {
                { "Building Gintze houses", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenBig", new() {
                { "Building Gintze houses", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenStalker", new() {
                { "Bird building alters", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenGiaHouse", new() {
                { "Gia living fruitfully", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenSeaTemple", new() {
                { "Definitely not making elder guardians from minecraft.", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenCatacombsWater2", new() {
                { "Definitely not making even more trapped elder guardians", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenCatacombsWater", new() {
                { "Definitely not making some trapped elder guardians", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenBridget", new() {
                { "The Almighty weapon being burried", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenCatacombsFlames", new() {
                { "Burning the world with catacombs", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenCatacombsTrap", new() {
                { "Trapping the world with catacombs", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenRallad", new() {
                { "Rallad killing people", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenMechShop", new() {
                { "Finding a place for the shop", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenAurelusTemple", new() {
                { "Singularities singing!", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenGovheilCastle", new() {
                { "Irradia marrying Paraffin instead of Delgrim", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenAbysm", new() {
                { "Shifting Shadows deep in the Ice", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenCinderspark", new() {
                { "Shifting Shadows deep in the Ice", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenVirulent", new() {
                { "Virulifying the Morrow", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenVeilSpot", new() {
                { "Residents of the veil believing in a god", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenVU", new() {
                { "Residents of the veil crafting chasms", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenAlcadSpot", new() {
                { "Fighting the Virulent with magic", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenRoyalCapital", new() {
                { "Fighting the Virulent with magic", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenIlluria", new() {
                { "Niivi protecting the cities above.", "不用输入汉化文本" },
            });
            ForceLocalizeSystem.LocalizeByType(typeof(StellaWorld), "WorldGenSylia", new() {
                { "Leaving the Royal Capital", "不用输入汉化文本" },
            });
            // ...
            // 写累了, 不想写了, 干脆直接给全部方法上上好了
        }
        foreach (var method in typeof(StellaWorld).GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static)) {
            if (method.DeclaringType != typeof(StellaWorld)) {
                continue;
            }
            ForceLocalizeSystem.Localize(method, worldGenLocalizations);
        }
        #endregion

        // TODO: Config 的 Headers
        // TODO: Currency (in Mod.Load)
        // TODO: Stellamenu.DisplayName?
    }
    private static bool AlwaysFalse() => false;
}
