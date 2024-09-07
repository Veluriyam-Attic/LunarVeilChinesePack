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
            { "Zui has something to offer you...", "填入汉化文本" },
            { "The Lunar tree rumbles...", "填入汉化文本" },
            { "The Abysm and Virulent stir...", "填入汉化文本" },
            { "Azurewrath's dreams alcadize the sky.", "填入汉化文本" },
            { "The toxic reunion begins! Gothivia's love bleeds through as the sun burns with everlasting hue.", "填入汉化文本" },
        });
        #endregion
        #region BloodCystDead
        ForceLocalizeSystem.LocalizeByTypeName(nameof(BloodCystDead), "AI", new() {
            { "...", "..." },
            { "The dread shrouds you...", "填入汉化文本" },
            { "Darkness...", "填入汉化文本" },
        });
        #endregion
        #region GothiviaDeath
        ForceLocalizeSystem.LocalizeByTypeName(nameof(GothiviaDeath), "AI", new() {
            { "Stoppp~", "填入汉化文本" },
            { "I'm cant-", "填入汉化文本" },
        });
        #endregion
        #region IrradiatedNest
        ForceLocalizeSystem.LocalizeByTypeName(nameof(IrradiatedNest), "SetBestiary", new() {
            { "A abomination housing the eggs for what seems to be a mechanical bird, born from the acid and a creation of Gia.", "填入汉化文本" },
            { "Irradiated Nest", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(IrradiatedNest), "AI", new() {
            { "A abomination housing the eggs for what seems to be a mechanical bird, born from the acid and a creation of Gia.", "填入汉化文本" },
            { "Irradiated Nest", "填入汉化文本" },
            { "Significant damage detected...", "填入汉化文本" },
            { "deploying Communication transmission device", "填入汉化文本" },
            { "Transmission successful!", "填入汉化文本" },
            { "Back up vessel destroyed...", "填入汉化文本" },
            { "Proceed with D. S. D. P!", "填入汉化文本" },
        });
        #endregion
        #region StarrVeriplant
        ForceLocalizeSystem.LocalizeByTypeName(nameof(StarrVeriplant), "SetBestiary", new() {
            { "A beloved magical stone guardian, protected the natural life and would petrify anyone who disturbs it.", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(StarrVeriplant), "Pulse", new() {
            { "Weak!", "填入汉化文本" },
            { "Armor Broke!", "填入汉化文本" },
            { "Player Wrath UP!", "填入汉化文本" },
            { "Player Speed UP!", "填入汉化文本" },
        });
        #endregion
        #region SunStalkerPreSpawn
        ForceLocalizeSystem.LocalizeByTypeName(nameof(StarrVeriplant), "AI", new() {
            { "The Sun...", "填入汉化文本" },
        });
        #endregion
        #region DiceinNPC
        ForceLocalizeSystem.LocalizeByTypeName("DiceinNPC", "AI", new() {
            { "Wohooo", "填入汉化文本" },
            { "Omg, its something!", "填入汉化文本" },
            { "Are you disappointed? You should be.", "填入汉化文本" },
            { "Wow, you have no maidens and no luck..", "填入汉化文本" },
            { "Sooo lucky!", "填入汉化文本" },
            { "WHATTT, you should not be this lucky..", "填入汉化文本" },
            { "Pfffft HAHA, laugh at this user.", "填入汉化文本" },
            { "Sometimes, you just have to tie your hair back and get on your knees.", "填入汉化文本" },
            { "Womp womp", "填入汉化文本" },
            { "NOW THIS IS AMAZEBALLS", "填入汉化文本" },
        });
        #endregion
        #region DesertRune
        ForceLocalizeSystem.LocalizeByTypeName("DesertRune", "HitEffect", new() {
            { "Desert Harvest Collected!", "填入汉化文本" },
        });
        #endregion
        #region IceRune
        ForceLocalizeSystem.LocalizeByTypeName("IceRune", "HitEffect", new() {
            { "Ice Harvest Collected!", "填入汉化文本" },
        });
        #endregion
        #region JungleRune
        ForceLocalizeSystem.LocalizeByTypeName("JungleRune", "HitEffect", new() {
            { "Jungle Harvest Collected!", "填入汉化文本" },
        });
        #endregion
        #region OceanRune
        ForceLocalizeSystem.LocalizeByTypeName("OceanRune", "HitEffect", new() {
            { "Ocean Harvest Collected!", "填入汉化文本" },
        });
        #endregion
        #region OverworldRune
        ForceLocalizeSystem.LocalizeByTypeName("OverworldRune", "HitEffect", new() {
            { "Overworld Harvest Collected!", "填入汉化文本" },
        });
        #endregion
        #region PearledGold
        ForceLocalizeSystem.LocalizeByTypeName("PearledGold", "HitEffect", new() {
            { "Veriplant Harvest Collected!", "填入汉化文本" },
        });
        #endregion
        #region SkyRune
        ForceLocalizeSystem.LocalizeByTypeName("SkyRune", "HitEffect", new() {
            { "Sky Harvest Collected!", "填入汉化文本" },
        });
        #endregion
        #region RedFlower
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(RedFlower).FullName, "HitEffect", new() {
            { "Flower destroyed", "填入汉化文本" },
        });
        #endregion
        #region WhiteFlower
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(WhiteFlower).FullName, "HitEffect", new() {
            { "Flower destroyed", "填入汉化文本" },
        });
        #endregion
        #region LonelySorceress
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(LonelySorceress).FullName, "SetBestiary", new() {
            { "A strange lady, she seems to overflow with magical energy!", "填入汉化文本" },
            { "Lonely Feeble Sorceress", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(LonelySorceress).FullName, "GetChat", new() {
            { "I wanna be like her", "填入汉化文本" },
            { "Mmm it's soo nice to meet you, wanna play with me :3", "填入汉化文本" },
            { "I'm all alone in this castle, if only someone could have fun with me :> ", "填入汉化文本" },
            { "Mwhahahahaha I am the most evil sorceress on the planet!!!", "填入汉化文本" },
            { "Obviously I want you to stay! Can you just stay here for a while- no, forever? I mean it isn't too much of an ask. ", "填入汉化文本" },
            { "There were these two that came by, one of them looked like me and had fox ears too! I wonder what breed she is.", "填入汉化文本" },
            { "This place can be shared by only us two you know, you can be here for me :)", "填入汉化文本" },
            { "Nobody really gets me you know, but I can see it in your eyes, we'll be made for each other :p", "填入汉化文本" },
            { "I think if you want to, maybe we can spar??? It would be so fun with you!", "填入汉化文本" },
            { "I think this place is accidently communistic...", "填入汉化文本" },
            { "Where did that Carian tome go?", "填入汉化文本" },
            { "Hii babe! Can we pleaseee fight? I haven't been able to do anything for sooo long and I just wanna have fun but nobody lets me do anything around here, so pretty pleasee", "填入汉化文本" },
            { "Funny enough I'm actually older than I act, take a guess I bet you didn't answer 26 lol!!", "填入汉化文本" },
            { "Shhh hush hun, we should try to spar instead :3", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeFullName(typeof(LonelySorceress).FullName, "SetNPCNameList", new() {
            { "Lonely Feeble Sorceress", "填入汉化文本" },
            { "Lonely Feeble Sorceress", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(LonelySorceress).FullName, "SetChatButtons", new() {
            { "Spar with your new wife", "填入汉化文本" },
        });
        #endregion
    }
}
