using Stellamod.NPCs.Bosses.DreadMire;
using Stellamod.NPCs.Bosses.GothiviaTheSun.GOS;
using Stellamod.NPCs.Bosses.INest;
using Stellamod.NPCs.Bosses.StarrVeriplant;
using Stellamod.NPCs.RoyalCapital;
using Stellamod.NPCs.Underground;

namespace LunarVeilChinesePack.NPCs;

public class MiscNPCLocalizer : ModSystem {
    public override void Load() {
        #region 某些 NPC 死亡时的消息
        ForceLocalizeSystem.LocalizeByTypeFullName("Stellamod.NPCs.Global.NPCMessages", "OnKill", new() {
            { "Zui has something to offer you...", "蕊有东西要给你！" },
            { "The Lunar tree rumbles...", "星月巨树颤抖着..." },
            { "The Abysm and Virulent stir...", "无尽深渊和瘴煞之地蠢蠢欲动..." },
            { "Azurewrath's dreams alcadize the sky.", "蔚蓝之梦将天空魔力化" },
            { "The toxic reunion begins! Gothivia's love bleeds through as the sun burns with everlasting hue.", "恒日高升，歌瑟梵的爱意从中渗出.团聚在即..." },
        });
        #endregion
        #region BloodCystDead
        ForceLocalizeSystem.LocalizeByTypeName(nameof(BloodCystDead), "AI", new() {
            { "...", "..." },
            { "The dread shrouds you...", "恐惧缠绞着你..." },
            { "Darkness...", "黑暗涌动..." },
        });
        #endregion
        #region GothiviaDeath
        ForceLocalizeSystem.LocalizeByTypeName(nameof(GothiviaDeath), "AI", new() {
            { "Stoppp~", "停——" },
            { "I'm cant-", "我不——" },
        });
        #endregion
        #region IrradiatedNest
        ForceLocalizeSystem.LocalizeByTypeName(nameof(IrradiatedNest), "SetBestiary", new() {
            { "A abomination housing the eggs for what seems to be a mechanical bird, born from the acid and a creation of Gia.", "一个扭曲的造物.其中装着一颗卵，看上去是机械制成的.吉娅结合了酸蚀之地的作品." },
            { "Irradiated Nest", "辐射巢穴" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(IrradiatedNest), "AI", new() {
            { "A abomination housing the eggs for what seems to be a mechanical bird, born from the acid and a creation of Gia.", "一个扭曲的造物.其中装着一颗卵，看上去是机械制成的.吉娅结合了酸蚀之地的作品." },
            { "Irradiated Nest", "辐射巢穴" },
            { "Significant damage detected...", "检测到严重损伤..." },
            { "deploying Communication transmission device", "启动通讯装置" },
            { "Transmission successful!", "成功连接！" },
            { "Back up vessel destroyed...", "后备机体已被摧毁..." },
            { "Proceed with D. S. D. P!", "运行程序 D.S.D.P.！" },
        });
        #endregion
        #region StarrVeriplant
        ForceLocalizeSystem.LocalizeByTypeName(nameof(StarrVeriplant), "SetBestiary", new() {
            { "A beloved magical stone guardian, protected the natural life and would petrify anyone who disturbs it.", "一具倍受喜爱的魔力石偶，保卫着自然生灵，擅闯者统统被其化作顽石." },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(StarrVeriplant), "Pulse", new() {
            { "Weak!", "虚弱！" },
            { "Armor Broke!", "护甲破碎！" },
            { "Player Wrath UP!", "玩家怒气加成！" },
            { "Player Speed UP!", "玩家速度加成！" },
        });
        #endregion
        #region SunStalkerPreSpawn
        ForceLocalizeSystem.LocalizeByTypeName(nameof(StarrVeriplant), "AI", new() {
            { "The Sun...", "烈日..." },
        });
        #endregion
        #region DiceinNPC
        ForceLocalizeSystem.LocalizeByTypeName("DiceinNPC", "AI", new() {
            { "Wohooo", "芜湖！" },
            { "Omg, its something!", "哎呦！掉东西了！" },
            { "Are you disappointed? You should be.", "失望吗？失望就对啦" },
            { "Wow, you have no maidens and no luck..", "幸运女神完全不搭理你呢" },
            { "Sooo lucky!", "幸运！" },
            { "WHATTT, you should not be this lucky..", "你怎么这么幸运？开挂了吧！" },
            { "Pfffft HAHA, laugh at this user.", "噗——哈哈哈！真是个倒霉蛋！" },
            { "Sometimes, you just have to tie your hair back and get on your knees.", "有时，你就该乖乖接受事实" },
            { "Womp womp", "嘟嘟~" },
            { "NOW THIS IS AMAZEBALLS", "震撼人心！" },
        });
        #endregion
        #region DesertRune
        ForceLocalizeSystem.LocalizeByTypeName("DesertRune", "HitEffect", new() {
            { "Desert Harvest Collected!", "收集了沙漠符文！" },
        });
        #endregion
        #region IceRune
        ForceLocalizeSystem.LocalizeByTypeName("IceRune", "HitEffect", new() {
            { "Ice Harvest Collected!", "收集了雪地符文！" },
        });
        #endregion
        #region JungleRune
        ForceLocalizeSystem.LocalizeByTypeName("JungleRune", "HitEffect", new() {
            { "Jungle Harvest Collected!", "收集了丛林符文！" },
        });
        #endregion
        #region OceanRune
        ForceLocalizeSystem.LocalizeByTypeName("OceanRune", "HitEffect", new() {
            { "Ocean Harvest Collected!", "收集了海洋符文！" },
        });
        #endregion
        #region OverworldRune
        ForceLocalizeSystem.LocalizeByTypeName("OverworldRune", "HitEffect", new() {
            { "Overworld Harvest Collected!", "收集了地表符文！" },
        });
        #endregion
        #region PearledGold
        ForceLocalizeSystem.LocalizeByTypeName("PearledGold", "HitEffect", new() {
            { "Veriplant Harvest Collected!", "收集了殆绿符文！" },
        });
        #endregion
        #region SkyRune
        ForceLocalizeSystem.LocalizeByTypeName("SkyRune", "HitEffect", new() {
            { "Sky Harvest Collected!", "收集了天空符文！" },
        });
        #endregion
        #region RedFlower
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(RedFlower).FullName, "HitEffect", new() {
            { "Flower destroyed", "收集了花束" },
        });
        #endregion
        #region WhiteFlower
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(WhiteFlower).FullName, "HitEffect", new() {
            { "Flower destroyed", "收集了花束" },
        });
        #endregion
        #region LonelySorceress
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(LonelySorceress).FullName, "SetBestiary", new() {
            { "A strange lady, she seems to overflow with magical energy!", "一名奇怪的女士.她身上的魔力几乎满溢..." },
            { "Lonely Feeble Sorceress", "孤独可怜的魔法少女" },
        });
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(LonelySorceress).FullName, "GetChat", new() {
            { "I wanna be like her", "我想要变成她那样" },
            { "Mmm it's soo nice to meet you, wanna play with me :3", "见到你真好啊，想要和我玩玩吗 :3" },
            { "I'm all alone in this castle, if only someone could have fun with me :> ", "天天呆在这城堡里，好寂寞哦..." },
            { "Mwhahahahaha I am the most evil sorceress on the planet!!!", "啊哈哈哈哈哈哈哈哈！我就是这个星球上最邪恶的魔法少女！！！" },
            { "Obviously I want you to stay! Can you just stay here for a while- no, forever? I mean it isn't too much of an ask. ", "我当然想要你留下啦！你能在这陪我一会...到永远吗？这不是什么大问题吧." },
            { "There were these two that came by, one of them looked like me and had fox ears too! I wonder what breed she is.", "之前有两个人从这路过，其中一个和我长得很像，甚至也有狐狸耳朵！我想认识认识她." },
            { "This place can be shared by only us two you know, you can be here for me :)", "你搬过来住吧！这样这里就只有我们两个啦！" },
            { "Nobody really gets me you know, but I can see it in your eyes, we'll be made for each other :p", "没有人理解我，但我从你的眼睛里能看得出，咱俩就是天作之合！" },
            { "I think if you want to, maybe we can spar??? It would be so fun with you!", "如果你想的话，咱们来玩玩吧！" },
            { "I think this place is accidently communistic...", "这里好像不小心变成共产主义国家了..." },
            { "Where did that Carian tome go?", "那本古籍哪去了？" },
            { "Hii babe! Can we pleaseee fight? I haven't been able to do anything for sooo long and I just wanna have fun but nobody lets me do anything around here, so pretty pleasee", "嗨~宝贝~能和我打一架吗？我在这里无所事事好长时间了，没人跟我玩...求求你啦！" },
            { "Funny enough I'm actually older than I act, take a guess I bet you didn't answer 26 lol!!", "我的年纪比看起来高哦~猜猜看？你肯定猜不中26的哈哈哈！" },
            { "Shhh hush hun, we should try to spar instead :3", "嘘，无需多言，来切磋一番吧！:3" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeFullName(typeof(LonelySorceress).FullName, "SetNPCNameList", new() {
            { "Lonely Feeble Sorceress", "孤独可怜的魔法少女" },
            { "Lonely Feeble Sorceress", "孤独可怜的魔法少女" },
        });
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(LonelySorceress).FullName, "SetChatButtons", new() {
            { "Spar with your new wife", "和你的新老婆来一场切磋！" },
        });
        #endregion
    }
}
