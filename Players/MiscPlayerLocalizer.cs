using Stellamod;
using Stellamod.Items.Accessories.Catacombs;

namespace LunarVeilChinesePack.Players;

public class MiscPlayerLocalizer : ModSystem {
    public override void Load() {
        #region 进入世界时的消息
        ForceLocalizeSystem.LocalizeByType(typeof(MyPlayer), nameof(MyPlayer.OnEnterWorld), new() {
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
        #region 某些时候会从玩家头上弹出的文字
        ForceLocalizeSystem.LocalizeByType(typeof(MyPlayer), nameof(MyPlayer.PostUpdate), new() {
            { "Wohooo", "芜湖！" },
            { "Omg, its something!", "哎呦！掉东西了！" },
            { "Are you disappointed? You should be.", "失望吗？失望就对啦" },
            { "Wow, you have no maidens and no luck..", "幸运女神完全不搭理你呢" },
            { "Sooo lucky!", "幸运！" },
            { "How can someone be so interesting?", "填入汉化文本" },
            { "Hiii its a me Bridget your friendly companion :3", "填入汉化文本" },
            { "Please dont replace me :(", "填入汉化文本" },
            { "This world is soo pretty! Just like you :p", "填入汉化文本" },
            { "Im so much better than Lucy :)", "填入汉化文本" },
            { "I used to have a roommate, they stink really badly", "填入汉化文本" },
            { "I love these journeys! I hope you won't throw me away...", "填入汉化文本" },
            { "Are you gonna get married someday? I'm always an option yknow >~<", "填入汉化文本" },
            { "When I was in my human form I was the Queen of the uh, morrow? I forgot.", "填入汉化文本" },
            { "Don't forget to brush your teeth! Its good for you :)", "填入汉化文本" },
            { "I completely forgot what it feels like to be flat and everyday you hold me is a reminder.", "填入汉化文本" },
            { "I can't tell if I like you holding me or sexual assault.", "填入汉化文本" },
            { "I have so many stories I can share to you :)", "填入汉化文本" },
            { "My sister turned me into a sword but I think you can get me out rightttt?", "填入汉化文本" },
            { "I totally don't like you at all, all you did was pull me from a stone yknow :(", "填入汉化文本" },
            { "You're soooo stupid :)", "填入汉化文本" },
            { "I'm you're daily reminder that you aren't alone :p", "填入汉化文本" },
            { "Hey so will you take me all the way to the end, I've taken a liking to you >:)", "填入汉化文本" },
            { "It's not hehe, its HEHE", "填入汉化文本" },
            { "I loveee painting, I think I could get back to form if I'm merged with something related", "填入汉化文本" },
            { "Use me for a spin will ya!", "填入汉化文本" },
            { "I'm not your normal yandere girl you know, please dont leave me :<", "填入汉化文本" },
            { "It's all fun and games until you get slashed by a dirt sword with boobs", "填入汉化文本" },
            { "I am so R rated", "填入汉化文本" },
            { "Shawty get your head in the game", "填入汉化文本" },
            { "Can we get to painting or volleyball pleasee?", "填入汉化文本" },
            { "You're holding me in all the right ways >:)", "填入汉化文本" },
            { "I dont care what you are, you obviously cared enough to get me :P", "填入汉化文本" },
            { "LALALA you're wrong I'm right LALALALA", "填入汉化文本" },
        });
        #endregion
        #region 钓鱼时
        ForceLocalizeSystem.LocalizeByType(typeof(MyPlayer), nameof(MyPlayer.CatchFish), new() {
            { "You feel threatened...", "填入汉化文本" },
        });
        #endregion
        #region 死亡信息
        ForceLocalizeSystem.LocalizeByType(typeof(MyPlayer), "CustomDeath", new() {
            { " was consumed by the abyss.", "填入汉化文本" },
            { " was contaminated", "填入汉化文本" },
            { "You touched a black hole... WHAT DID YOU THINK WOULD HAPPEN?", "填入汉化文本" },
        });
        #endregion
    }
}
