using Stellamod.NPCs.Abyssal;
using Stellamod.NPCs.Bosses.Azurerin;
using Stellamod.NPCs.Bosses.Caeva;
using Stellamod.NPCs.Bosses.DaedusRework;
using Stellamod.NPCs.Bosses.DreadMire;
using Stellamod.NPCs.Bosses.DreadMire.Heart;
using Stellamod.NPCs.Bosses.DreadMire.Monolith;
using Stellamod.NPCs.Bosses.Ereshkigal;
using Stellamod.NPCs.Bosses.Fenix;
using Stellamod.NPCs.Bosses.GothiviaNRek.Gothivia;
using Stellamod.NPCs.Bosses.GothiviaNRek.Reks;
using Stellamod.NPCs.Bosses.GothiviaTheSun.GOS;
using Stellamod.NPCs.Bosses.INest;
using Stellamod.NPCs.Bosses.IrradiaNHavoc;
using Stellamod.NPCs.Bosses.IrradiaNHavoc.Irradia;
using Stellamod.NPCs.Bosses.Jack;
using Stellamod.NPCs.Bosses.Niivi;
using Stellamod.NPCs.Bosses.singularityFragment;
using Stellamod.NPCs.Bosses.STARBOMBER;
using Stellamod.NPCs.Bosses.StarrVeriplant;
using Stellamod.NPCs.Bosses.SunStalker;
using Stellamod.NPCs.Bosses.SupernovaFragment;
using Stellamod.NPCs.Bosses.Sylia;
using Stellamod.NPCs.Bosses.Verlia.Projectiles;
using Stellamod.NPCs.Catacombs.Fire;
using Stellamod.NPCs.Critters;
using Stellamod.NPCs.Event.Gintzearmy.BossGintze;
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
        ForceLocalizeSystem.LocalizeByType(typeof(LonelySorceress), "GetChat", new() {
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
        ForceLocalizeSystem.LocalizeInOrderByType(typeof(LonelySorceress), "SetNPCNameList", new() {
            { "Lonely Feeble Sorceress", "孤独可怜的魔法少女" },
            { "Lonely Feeble Sorceress", "孤独可怜的魔法少女" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(LonelySorceress), "SetChatButtons", new() {
            { "Spar with your new wife", "和你的新老婆切磋一番！" },
        });
        #endregion

        #region Bosses

        #region BloodCystDead
        ForceLocalizeSystem.LocalizeByType(typeof(BloodCystDead), nameof(BloodCystDead.AI), new() {
            { "...", "..." },
            { "The dread shrouds you...", "恐惧缠绞着你..." },
            { "Darkness...", "黑暗涌动..." },
        });
        #endregion

        #region EreshkigalIdle
        ForceLocalizeSystem.LocalizeByType(typeof(EreshkigalIdle), nameof(EreshkigalIdle.GetChat), new() {
            { "Leave me and my husband alone", "让我和我的丈夫在这里独享二人时光吧" },
            { "You should all be jealous that I'm here.", "你们都应该羡慕我！" },
            { "Welcome welcome! Come here to feast your eyes on us?", "欢迎！欢迎！来一饱眼福吧" },
            { "Oh dear Sigfried how we've met..", "亲爱的齐格飞...我还记得我们相遇的那天..." },
            { "Come and go you will, you'll be broken more than the others.", "匆忙的来，匆忙的走，将自己搞得支离破碎..." },
            { "...", "..." },
        });
        ForceLocalizeSystem.LocalizeInOrderByType(typeof(EreshkigalIdle), nameof(EreshkigalIdle.SetNPCNameList), new() {
            { "Ereshkigal the Lover", "痴恋者厄莉什基迦勒" },
            { "Ereshkigal the Lover", "痴恋者厄莉什基迦勒" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(EreshkigalIdle), nameof(EreshkigalIdle.SetChatButtons), new() {
            { "Give her something.", "给她送一件礼物" },
            { "Sigfried?", "询问关于齐格飞" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(EreshkigalIdle), nameof(EreshkigalIdle.OnChatButtonClicked), new() {
            { "OMG, OMG OMG OMG OMG", "天哪天哪天哪天哪！！" },
            { "What is this? Nothing of importance to me... You are worthless, you're life is as valuable as a cinderspark summer ant, you mean nothing. You should get me something good NOW. You should burn in the Cinderspark..", "这是什么...不要紧，它和你一样毫无用处，像一只蚂蚁一样不值一提.赶紧给我找到点有价值的东西，不然我就把你扔到烬火之地永世焚烧." },
            { "Oh what a darling he is. Too bad I'm tasked with keeping him here forever right? He can't escape me :3 ", "我的任务就是把他永远关在这里，对他来说可不是什么好消息对吧 :3" },
            { "Sigfried is my husband you know. We met on the sacred lands of the Illuria, I may have been kicked out numerous times to talk to my king but I'd do anything to get with him", "我丈夫就是齐格飞.我们初次见面是在星树的圣地，我已经被他的守卫赶出那里不知道多少次了，但为了他这一切都值得." },
            { "He's so pure, going for such high level threats such as Lumi and stealing her singularity. That's the type of man I like, one who isn't afraid to get their hands dirty.", "他是那么的纯粹，敢向琉明那样的高级威胁下手，还偷走了她的奇点！我就喜欢这种干事干净利落毫无顾忌的男人." },
            { "I wish we could stay together always.", "我们要永远在一起~" },
            { "Oh his dear Mordred, I bet he doesn't even know hit wife was trapped within a weapon :)", "哦，那个莫德雷德呀...我敢肯定他都不知道他的妻子已经被囚禁在一把武器里了." },
            { "Stupid dragon always getting in the way to getting to my wonderous babe, I would trap it as well but then it'd anger my dearest here.", "那条蠢龙，总是守着我的宝贝不让我靠近...要不是我丈夫会生气，我早就把那龙也关到这里了." },
            { "How many doors do I need to store Lumi? I don't really know but I don't care. As long as she doesn't come after my husband.", "我要用多少扇门才能困住琉明？算了，也不重要，只要她不来找我的丈夫就行." },
        });
        #endregion

        #region GothiviaDeath
        ForceLocalizeSystem.LocalizeByTypeName(nameof(GothiviaDeath), "AI", new() {
            { "Stoppp~", "停——" },
            { "I'm cant-", "我不——" },
        });
        #endregion
        #region GothiviaIdle
        ForceLocalizeSystem.LocalizeByType(typeof(GothiviaIdle), nameof(GothiviaIdle.GetChat), new() {
            { "...", "..." },
            { "I shouldn't have left..", "或许我就不该离开..." },
            { "Verlia.. Irradia...", "薇莉娅...伊瑞蒂安..." },
            { "A monster you are", "你真是个怪物" },
            { "...Interesting...", "...有点东西..." },
        });
        ForceLocalizeSystem.LocalizeInOrderByType(typeof(GothiviaIdle), nameof(GothiviaIdle.SetNPCNameList), new() {
            { "Gothivia The Enraged", "盛怒烈阳 歌瑟梵" },
            { "Gothivia The Enraged", "盛怒烈阳 歌瑟梵" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(GothiviaIdle), nameof(GothiviaIdle.SetChatButtons), new() {
            { "Challenge.", "挑战" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(GothiviaIdle), nameof(GothiviaIdle.OnChatButtonClicked), new() {
            { "You're not worth the effort, Rek can avenge them for me. Idiot.", "让莱克为她们复仇吧.对付你不需要我亲自出手，蠢货." },
        });
        #endregion
        
        #region IrradiatedNest
        ForceLocalizeSystem.LocalizeByTypeName(nameof(IrradiatedNest), "AI", new() {
            { "Significant damage detected...", "检测到严重损伤..." },
            { "deploying Communication transmission device", "启动通讯装置" },
            { "Transmission successful!", "成功连接！" },
            { "Back up vessel destroyed...", "后备机体已被摧毁..." },
            { "Proceed with D. S. D. P!", "运行程序 D.S.D.P.！" },
        });
        #endregion

        #region IrradiaIdle
        ForceLocalizeSystem.LocalizeByType(typeof(IrradiaIdle), nameof(IrradiaIdle.GetChat), new() {
            { "...", "..." },
            { "Leave before you too become corrupt", "在你也被腐化之前离开这里" },
            { "Get away from here.", "滚出这里." },
            { "I miss them", "我想她们..." },
            { "... Delgrim...", "...戴尔格林..." },
        });
        ForceLocalizeSystem.LocalizeInOrderByType(typeof(IrradiaIdle), nameof(IrradiaIdle.SetNPCNameList), new() {
            { "???", "???" },
            { "???", "???" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(IrradiaIdle), nameof(IrradiaIdle.SetChatButtons), new() {
            { "Show Verlia's Manifested Bravery", "展示薇莉娅的灵魂核心" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(IrradiaIdle), nameof(IrradiaIdle.OnChatButtonClicked), new() {
            { "Stop bothering me, you don't deserve to die.", "别来烦我.你都不值得被我亲手杀死." },
        });
        #endregion

        #region StarrVeriplant
        ForceLocalizeSystem.LocalizeByType(typeof(StarrVeriplant), "Pulse", new() {
            { "Weak!", "虚弱！" },
            { "Armor Broke!", "护甲破碎！" },
            { "Player Wrath UP!", "玩家怒气加成！" },
            { "Player Speed UP!", "玩家速度加成！" },
        });
        #endregion

        #region SunStalkerPreSpawn
        ForceLocalizeSystem.LocalizeByType(typeof(StarrVeriplant), nameof(StarrVeriplant.AI), new() {
            { "The Sun...", "烈日..." },
        });
        #endregion

        #region UnderworldRift
        ForceLocalizeSystem.LocalizeByType(typeof(UnderworldRift), nameof(UnderworldRift.GetChat), new() {
            { "...", "..." },
        });
        ForceLocalizeSystem.LocalizeInOrderByType(typeof(UnderworldRift), nameof(UnderworldRift.SetNPCNameList), new() {
            { "Underworld Rift", "地狱裂隙" },
            { "Underworld Rift", "地狱裂隙" },
        });
        ForceLocalizeSystem.LocalizeByType(typeof(UnderworldRift), nameof(UnderworldRift.SetChatButtons), new() {
            { "Disturb Rift", "试探裂隙" },
        });
        #endregion

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
    }
}
